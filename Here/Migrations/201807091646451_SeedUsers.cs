namespace Here.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'41a3a3fa-726d-4d22-9d3d-789f8d81bfa1', N'guest@here.com', 0, N'AItCNEZQEP2neJMr9mFVOd1DlHCwj7zUqpafncsD7qNALBVewMzPqYYl25j3Rn+j4w==', N'3dc5343c-74f2-4b9b-9435-2a9e109c90f6', NULL, 0, 0, NULL, 1, 0, N'guest@here.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'db60873e-3abc-48aa-9b63-7117020d61a1', N'anna.tutaj@here.com', 0, N'ACWle9JTu/lVlsFdGZJyEOcU7Au9HqfcFCYj925wODgLL9IKARieWv/0qtCD2QIm5Q==', N'2f8a9f98-ac4e-42c7-92d1-ee8095115a8a', NULL, 0, 0, NULL, 1, 0, N'anna.tutaj@here.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'0b676fd1-0be3-402b-994e-859cc55c0be9', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'db60873e-3abc-48aa-9b63-7117020d61a1', N'0b676fd1-0be3-402b-994e-859cc55c0be9')

");
        }

        public override void Down()
        {
        }
    }
}
