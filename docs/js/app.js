(() => {
  // ── Intersection observer (tracks viewport entry) ────────────────────────
  let revealObserver = null;

  const observe = (el) => {
    if (revealObserver && !el.classList.contains("visible")) {
      revealObserver.observe(el);
    }
  };

  const buildRevealObserver = () => {
    if (!("IntersectionObserver" in window)) {
      // No IO support — just show everything
      document.querySelectorAll(".reveal").forEach((el) =>
        el.classList.add("visible")
      );
      return;
    }

    revealObserver = new IntersectionObserver(
      (entries) => {
        entries.forEach((entry) => {
          if (entry.isIntersecting) {
            entry.target.classList.add("visible");
            revealObserver.unobserve(entry.target);
          }
        });
      },
      { threshold: 0.08 }
    );

    // Observe anything already in the DOM
    document.querySelectorAll(".reveal:not(.visible)").forEach(observe);

    // ── MutationObserver: catch elements added by Blazor WASM after load ───
    const mo = new MutationObserver((mutations) => {
      mutations.forEach((mut) => {
        mut.addedNodes.forEach((node) => {
          if (node.nodeType !== 1) return; // elements only
          if (node.classList && node.classList.contains("reveal")) {
            observe(node);
          }
          // Also scan descendants
          if (node.querySelectorAll) {
            node
              .querySelectorAll(".reveal:not(.visible)")
              .forEach(observe);
          }
        });
      });
    });

    mo.observe(document.body, { childList: true, subtree: true });
  };

  // ── Sticky nav + mobile hamburger ────────────────────────────────────────
  const initNav = () => {
    const header = document.querySelector("[data-nav]");
    const toggle = document.querySelector("[data-nav-toggle]");
    const menu = document.querySelector("[data-nav-menu]");

    const setHeader = () => {
      if (!header) return;
      header.classList.toggle("scrolled", window.scrollY > 12);
    };

    setHeader();
    window.removeEventListener("scroll", setHeader);
    window.addEventListener("scroll", setHeader, { passive: true });

    if (toggle && menu && !toggle.dataset.bound) {
      toggle.dataset.bound = "true";
      toggle.addEventListener("click", () => {
        const open = menu.classList.toggle("open");
        toggle.setAttribute("aria-expanded", String(open));
      });
      menu.addEventListener("click", (e) => {
        if (e.target.closest("a")) {
          menu.classList.remove("open");
          toggle.setAttribute("aria-expanded", "false");
        }
      });
    }
  };

  // ── Boot ─────────────────────────────────────────────────────────────────
  const init = () => {
    initNav();
    buildRevealObserver();
  };

  // Run immediately (handles static content) and also after Blazor navigates
  if (document.readyState === "loading") {
    document.addEventListener("DOMContentLoaded", init);
  } else {
    init();
  }

  // Blazor WASM fires this on soft navigation; re-init nav state
  document.addEventListener("enhancedload", initNav);
})();
