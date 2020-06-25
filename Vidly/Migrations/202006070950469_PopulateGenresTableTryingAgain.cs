namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenresTableTryingAgain : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Genres ON INSERT INTO Genres (Id, GenreType) VALUES (1, 'Comedy')");
            Sql("SET IDENTITY_INSERT Genres ON INSERT INTO Genres (Id, GenreType) VALUES (2, 'Action')");
            Sql("SET IDENTITY_INSERT Genres ON INSERT INTO Genres (Id, GenreType) VALUES (3, 'Thriller')");
            Sql("SET IDENTITY_INSERT Genres ON INSERT INTO Genres (Id, GenreType) VALUES (4, 'Family')");
            Sql("SET IDENTITY_INSERT Genres ON INSERT INTO Genres (Id, GenreType) VALUES (5, 'Romance')");
        }
        
        public override void Down()
        {
        }
    }
}
