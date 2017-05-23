namespace Portfolio.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Collections.Generic;
    using Portfolio.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Portfolio.Models.PortfolioDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "Portfolio.Models.PortfolioDB";
        }

        protected override void Seed(Portfolio.Models.PortfolioDB context)
        {
            context.ProjectTypes.AddOrUpdate(r => r.Name, new ProjectType { Id = 0, Name = "Development" }, new ProjectType { Id = 1, Name = "Design" }, new ProjectType { Id = 2, Name = "Audio" });
            context.Projects.AddOrUpdate(r => r.Title, new Models.Project { Title = "Thunder Heads", Description = "Web site for @okcthunderheads Podcast. Used HTML5 / CSS / Bootstrap framework to customize a bootstrap template to fit the needs of the site.", TypeId = 0 });
            context.Projects.AddOrUpdate(r => r.Title, new Models.Project { Title = "GillianB.com", Description = "Customized CSS and HTML for GillianB.com online class platform Thinkific.", TypeId = 0 });
            context.Projects.AddOrUpdate(r => r.Title, new Models.Project { Title = "Wolves I - Bon Iver Cover", Description = "Acoustic cover of Bon Iver's Wolves from the album For Emma, Forever Ago", TypeId = 2 });

        }
    }

}
