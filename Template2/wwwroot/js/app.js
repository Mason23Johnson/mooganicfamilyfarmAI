(() => {
  let observer;

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

      menu.addEventListener("click", (event) => {
        if (event.target.closest("a")) {
          menu.classList.remove("open");
          toggle.setAttribute("aria-expanded", "false");
        }
      });
    }
  };

  const initReveal = () => {
    const revealItems = document.querySelectorAll(".reveal:not(.visible)");
    if (!("IntersectionObserver" in window)) {
      revealItems.forEach((item) => item.classList.add("visible"));
      return;
    }

    if (observer) observer.disconnect();
    observer = new IntersectionObserver((entries) => {
      entries.forEach((entry) => {
        if (entry.isIntersecting) {
          entry.target.classList.add("visible");
          observer.unobserve(entry.target);
        }
      });
    }, { threshold: 0.12 });

    revealItems.forEach((item) => observer.observe(item));
  };

  const init = () => {
    initNav();
    initReveal();
  };

  init();
  document.addEventListener("enhancedload", init);
})();
