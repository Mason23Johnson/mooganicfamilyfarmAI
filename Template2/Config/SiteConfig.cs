namespace BlazorBusinessTemplate.Config;

// Edit this file to rebrand the whole site. Pick a theme in App.razor via
// the Theme property, then adjust content arrays without touching component code.
public class SiteConfig
{
    public string SiteName { get; init; } = "Mooganic Family Farm";
    public string SiteSlogan { get; init; } = "Grown from the heart";
    public string Tagline { get; init; } = "Food, family, and farm life";
    public string Description { get; init; } =
        "Mooganic Family Farm is a cozy family blog run by Michelle Anderson and her crew. We share real recipes, garden stories, farm life, and the honest beautiful mess of family living close to the earth.";

    public string Theme { get; init; } = "farm";

    public NavItem[] NavItems { get; init; } =
    [
        new("Home", "/"),
        new("About", "/about"),
        new("Blog", "/blog"),
        new("Pinterest", "/pinterest"),
        new("Contact", "/contact"),
    ];

    public string NavCTALabel { get; init; } = "Join Our Family";
    public string NavCTAUrl { get; init; } = "/contact";

    public string HeroPreLabel { get; init; } = "A real family. Real food. Real life on the farm.";
    public string HeroHeadline { get; init; } = "Welcome To Our Little Farm";
    public string HeroSubheadline { get; init; } =
        "Hi, I'm Michelle! This is our cozy corner of the internet where my family shares recipes we actually cook, stories from our garden, and the honest beautiful mess of farm family life.";
    public string HeroPrimaryCTA { get; init; } = "Read Our Latest Recipes";
    public string HeroPrimaryUrl { get; init; } = "/blog";
    public string HeroSecondaryCTA { get; init; } = "Find Us On Pinterest";
    public string HeroSecondaryUrl { get; init; } = "/pinterest";

    public Feature[] Features { get; init; } =
    [
        new("Recipes We Actually Make", "Weeknight dinners, weekend bakes, and the ugly-beautiful food that feeds this family. No fancy techniques, just real kitchen life.", "chat", "span-2"),
        new("Garden & Growing", "What's coming up in the beds this season, what works, what the deer ate, and how to grow food you'll actually eat.", "bolt", ""),
        new("Farm Life", "The chickens, the mud, the early mornings, and why we chose this slower, better way of living together.", "spark", ""),
        new("Four Family Voices", "Michelle writes most posts but Jake, Maddie, and Cooper all take over the blog when they have something to say.", "grid", "span-2"),
        new("DIY & Homesteading", "Canning, preserving, building the raised beds, fixing the fence. Projects we tackled ourselves.", "sliders", ""),
        new("Seasonal Living", "We cook what's growing. We celebrate what's in season. We live close to the earth on purpose.", "gem", ""),
    ];

    public Stat[] Stats { get; init; } =
    [
        new("200+", "Family Recipes"),
        new("4", "Family Writers"),
        new("1", "Very Good Dog"),
        new("∞", "Made with Love"),
    ];

    public Service[] Services { get; init; } =
    [
        new("Dinner Recipes", "The real weeknight meals our family comes back to again and again.", "target", ["One-pot dinners", "Slow cooker magic", "30-minute meals", "Kid-approved plates"]),
        new("Baking & Desserts", "Breads, pies, cookies, and the cakes that make birthdays worth celebrating.", "spark", ["Farmhouse sourdough", "Seasonal pies", "Easy cookies", "Layer cakes"]),
        new("Garden & Grow", "From seed to table, what we've learned growing our own food.", "bolt", ["What we plant", "Raised bed tips", "Composting basics", "Pest-free gardening"]),
        new("Farm Life Stories", "The unfiltered stories from raising animals and living closer to the land.", "chat", ["Chicken keeping", "Morning routines", "Seasonal rhythms", "Farm lessons"]),
        new("Preserving & Canning", "Putting up the harvest so good food lasts year-round.", "gem", ["Water bath canning", "Freezer meals", "Ferments & pickles", "Jam making"]),
        new("Family & Home", "The spaces, traditions, and little rituals that hold a family together.", "grid", ["Farmhouse home", "Family traditions", "Kids on the farm", "Slow living"]),
    ];

    public HowItWorksStep[] Steps { get; init; } =
    [
        new("01", "We Grow It", "Something comes up in the garden or out on the farm. We pay attention, we learn, and we share what's real."),
        new("02", "We Cook It", "Michelle, Jake, Maddie, or Cooper takes over the kitchen. We test, taste, and share the actual recipe."),
        new("03", "We Share It", "Stories, recipes, tips, and honest moments land here on the blog and over on our Pinterest boards. Pull up a chair."),
    ];

    public Testimonial[] Testimonials { get; init; } =
    [
        new("Amber T.", "Reader", "Mooganic Family Farm", 5, "Michelle's weeknight recipes are the only ones my picky eater actually finishes. This blog is a lifesaver on busy Tuesdays."),
        new("Greg & Lisa M.", "Readers", "Mooganic Family Farm", 5, "We started our raised beds last spring using Michelle's guide. First harvest was last August and we're hooked forever."),
        new("Dana K.", "Pinterest Follower", "Mooganic Family Farm", 5, "Found the Pinterest boards first and I've been following ever since. The chicken keeping series got us to finally get backyard hens."),
        new("Carla B.", "Blog Reader", "Mooganic Family Farm", 5, "Cooper's snack post made me laugh out loud. This family is the real deal and their food actually tastes good."),
    ];

    public bool ShowPricingToggle { get; init; } = false;
    public PricingTier[] PricingTiers { get; init; } = [];

    public FaqItem[] Faqs { get; init; } =
    [
        new("Where are you located?", "We're on a small family farm in the rural Midwest. We don't share the exact address but we love hearing from families in similar places!"),
        new("Do you accept recipe submissions?", "Not right now, but we love it when readers share what they made using our recipes. Tag us on Pinterest!"),
        new("Can I share your recipes?", "Yes! Please link back to the original post here on the blog. We'd love the credit and we'd love to see what you made."),
        new("How often do you post?", "Michelle posts 2-3 times a week. Jake, Maddie, and Cooper chime in when the spirit moves them, which keeps things wonderfully unpredictable."),
        new("Are you on Instagram?", "We're working on it! For now, find us on Pinterest where we have boards for recipes, garden, farm life, and family."),
    ];

    public BlogPost[] BlogPosts { get; init; } =
    [
        new("The Soup That Saved Our October Evenings", "Recipes", "May 20, 2026", "6 min read", "A thick, creamy potato leek soup that comes together in under 40 minutes. Michelle makes it every October and the kids have stopped complaining about dinner.", "Michelle", "https://images.unsplash.com/photo-1547592180-85f173990554?w=600&q=80&auto=format&fit=crop"),
        new("What Actually Happened When We Got Chickens", "Farm Life", "May 12, 2026", "8 min read", "Jake here. Michelle wanted chickens. I said sure. Here's the honest story of the first six months, the raccoon incident, and why we now have seventeen hens.", "Jake", "https://images.unsplash.com/photo-1548550023-2bdb3c5beed7?w=600&q=80&auto=format&fit=crop"),
        new("ok our garden shed is literally a whole vibe now", "Family", "May 5, 2026", "4 min read", "my mom let me help redo the garden shed and honestly it turned out so good. i'm obsessed with the little shelf we put in.", "Maddie", "https://images.unsplash.com/photo-1416879595882-3373a0480b5b?w=600&q=80&auto=format&fit=crop"),
        new("My Favrite Snack For Saturdays", "Family", "Apr 28, 2026", "2 min read", "Hi im Cooper. I have a really good snack setup for Saturdays. my mom said I can tell you about it.", "Cooper", "https://images.unsplash.com/photo-1543362906-acfc16c67564?w=600&q=80&auto=format&fit=crop"),
        new("Farmhouse Sourdough For People Who've Killed Starter Before", "Recipes", "Apr 20, 2026", "10 min read", "This is the sourdough guide I wish I'd had three dead starters ago. We're keeping it alive now and the bread is honestly everything.", "Michelle", "https://images.unsplash.com/photo-1559620192-032c4bc4674e?w=600&q=80&auto=format&fit=crop"),
        new("Raised Beds Year Two: What Changed, What Stayed", "Garden", "Apr 10, 2026", "7 min read", "Second year in the raised beds and we finally feel like we know what we're doing. Here's what worked, what didn't, and what we're planting this season.", "Michelle", "https://images.unsplash.com/photo-1416879595882-3373a0480b5b?w=600&q=80&auto=format&fit=crop"),
    ];

    public PortfolioItem[] PortfolioItems { get; init; } = [];

    public string ContactEmail { get; init; } = "hello@mooganicfamilyfarm.com";
    public string ContactPhone { get; init; } = "";
    public string ContactAddress { get; init; } = "Somewhere in the rural Midwest";

    public SocialLink[] SocialLinks { get; init; } =
    [
        new("Pinterest", "https://pinterest.com/mooganicfamilyfarm", "P"),
        new("Instagram", "https://instagram.com", "IG"),
    ];

    public string FooterTagline { get; init; } = "A real family, a real farm, and real food made with love. Thanks for being here with us.";
    public string CopyrightYear { get; init; } = "2026";
    public FooterColumn[] FooterColumns { get; init; } =
    [
        new("On The Blog", [new("Recipes", "/blog"), new("Farm Life", "/blog"), new("Garden", "/blog"), new("Family", "/blog")]),
        new("Our Family", [new("About Us", "/about"), new("Meet Michelle", "/about"), new("The Kids", "/about"), new("Contact", "/contact")]),
        new("Find Us", [new("Pinterest", "/pinterest"), new("Instagram", "#"), new("Subscribe", "/contact"), new("Press", "#")]),
        new("Site", [new("Privacy Policy", "/privacypolicy"), new("Terms", "#"), new("Accessibility", "#"), new("Cookies", "#")]),
    ];

    public string AboutMission { get; init; } =
        "We believe food is how families stay close. We share what we grow, what we cook, and the honest imperfect beautiful life we're living on this little farm together.";
    public string AboutStory { get; init; } =
        "Mooganic Family Farm started as a way for Michelle to keep her recipes in one place. It turned into a whole family affair. Jake writes about the farm and the grill. Maddie covers the things only a teenager notices. Cooper checks in when something is really really cool. And Biscuit, our dog, mostly just wanders through the background of every photo.";

    public TeamMember[] Team { get; init; } =
    [
        new("Michelle Anderson", "Mom · Blog Mama · Head Cook", "I do most of the writing here. I cook, I garden, I figure things out the slow way, and I share what works. This blog is my love letter to our little family."),
        new("Jake Anderson", "Dad · Grillmaster · Fix-It Guy", "Michelle lets me have the keyboard when there's something worth grilling or a project in the garage. Dry humor, real talk, no fancy words."),
        new("Maddie Anderson", "Daughter · 14 · Occasional Blogger", "hi i'm Maddie. i write here sometimes about stuff i actually care about. my posts are usually shorter than mom's and honestly more honest."),
        new("Cooper Anderson", "Son · 9 · Snack Expert", "Hi im Cooper. I like Pokemon and Biscuit and snacks. Mom said I can write here when I want. I think my posts are the best ones."),
    ];

    public CompanyValue[] Values { get; init; } =
    [
        new("Real Food", "We cook what we'd actually eat on a Tuesday night. No fancy Instagram props, no techniques that take three hours.", "spark"),
        new("Honest Stories", "Farm life is beautiful and also muddy and occasionally a total disaster. We share all of it.", "chat"),
        new("Family First", "Every decision on this blog comes back to: is this good for our family? We hope it's good for yours too.", "gem"),
        new("Slow & Intentional", "We moved to the farm to slow down. The blog reflects that. We'd rather do a few things well than everything fast.", "sliders"),
    ];

    public string PinterestUrl { get; init; } = "https://pinterest.com/mooganicfamilyfarm";

    public PinterestBoard[] PinterestBoards { get; init; } =
    [
        new("Farmhouse Recipes", "Our most saved recipes. Weeknight dinners, weekend bakes, and everything in between.", "https://pinterest.com/mooganicfamilyfarm/farmhouse-recipes", "https://images.unsplash.com/photo-1556909114-f6e7ad7d3136?w=500&q=80&auto=format&fit=crop"),
        new("Garden & Growing", "Raised beds, seed starting, companion planting, and what's actually coming up right now.", "https://pinterest.com/mooganicfamilyfarm/garden", "https://images.unsplash.com/photo-1416879595882-3373a0480b5b?w=500&q=80&auto=format&fit=crop"),
        new("Farm Life", "Chickens, mornings, the view from the porch. Stories and photos from the everyday farm.", "https://pinterest.com/mooganicfamilyfarm/farm-life", "https://images.unsplash.com/photo-1500595046743-cd271d694d30?w=500&q=80&auto=format&fit=crop"),
        new("Preserving & Canning", "How we put up the harvest. Jams, pickles, canned tomatoes, and freezer meals.", "https://pinterest.com/mooganicfamilyfarm/preserving", "https://images.unsplash.com/photo-1568702846914-96b305d2aaeb?w=500&q=80&auto=format&fit=crop"),
    ];
}

public record NavItem(string Label, string Url);
public record Feature(string Title, string Description, string Icon, string Span);
public record Stat(string Value, string Label);
public record Service(string Title, string Description, string Icon, string[] Details);
public record HowItWorksStep(string Number, string Title, string Description);
public record Testimonial(string Name, string Role, string Company, int Stars, string Quote);
public record PricingTier(string Name, string MonthlyPrice, string AnnualPrice, string Description, string[] Features, bool IsPopular, string CtaUrl);
public record FaqItem(string Question, string Answer);
public record BlogPost(string Title, string Category, string Date, string ReadTime, string Excerpt, string Author = "Michelle", string ImageUrl = "https://images.unsplash.com/photo-1500382017468-9049fed747ef?w=600&q=80&auto=format&fit=crop");
public record PortfolioItem(string Title, string Industry, string Result, string[] Tags);
public record SocialLink(string Platform, string Url, string Icon);
public record FooterColumn(string Title, FooterLink[] Links);
public record FooterLink(string Label, string Url);
public record TeamMember(string Name, string Role, string Bio);
public record CompanyValue(string Title, string Description, string Icon);
public record PinterestBoard(string Title, string Description, string PinterestUrl, string ImageUrl);
