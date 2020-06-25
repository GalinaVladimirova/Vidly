namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c76cc6c9-7815-41d6-b5b8-b9090686c57c', N'admin@vidly.com', 0, N'ALsZCrJ6RyDmVQonhNE88nwjlfYeOnhWN1wy7sb+PAMCTS7ZPte4sIy2YAreHuutKQ==', N'54ad84a5-d096-46eb-a959-a93c125cdd91', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'fe5e3999-544f-40e0-96d9-33c696e1637b', N'guest@vidly.com', 0, N'AMDHFLSx1n/vl3Q2xqHe7ViNMCTRCSBoi+UOv85eKbidYc+oSxlYiB6YZ5OEehlH3Q==', N'fd68fc61-6621-4b09-b40e-89719687eb29', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'ceca2dd9-51ab-4948-8394-9b7a614f921c', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'c76cc6c9-7815-41d6-b5b8-b9090686c57c', N'ceca2dd9-51ab-4948-8394-9b7a614f921c')
");
        }
        
        public override void Down()
        {
        }
    }
}
