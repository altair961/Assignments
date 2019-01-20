USE Zza

CREATE TABLE dbo.Products(
	[Id]	int IDENTITY(1,1) PRIMARY KEY,
	[Name]	varchar(125)
)

CREATE TABLE dbo.Categories(
	[Id]	int IDENTITY(1,1) PRIMARY KEY,
	[Name]	varchar(125)
)

CREATE TABLE dbo.ProductsCategories(
	[Id]	int IDENTITY(1,1) PRIMARY KEY,
	[ProductId]	int,
	[CategoryId] int
)

INSERT INTO [dbo].[Products]
           ([Name])
     VALUES
           ('SpaceShuttle')

INSERT INTO [dbo].[Products]
           ([Name])
     VALUES
           ('StatueOfLiberty')

INSERT INTO [dbo].[Products]
           ([Name])
     VALUES
           ('TeddyBear')

INSERT INTO [dbo].[Products]
           ([Name])
     VALUES
           ('Keyboard')

INSERT INTO [dbo].[Categories]
           ([Name])
     VALUES
           ('Souvenirs')
		   
INSERT INTO [dbo].[Categories]
           ([Name])
     VALUES
           ('Toys')

INSERT INTO [dbo].[ProductsCategories]
           ([ProductId],[CategoryId])
     VALUES
           (1,1)

INSERT INTO [dbo].[ProductsCategories]
           ([ProductId],[CategoryId])
     VALUES
           (1,2)

INSERT INTO [dbo].[ProductsCategories]
           ([ProductId],[CategoryId])
     VALUES
           (2,1)
	
INSERT INTO [dbo].[ProductsCategories]
           ([ProductId],[CategoryId])
     VALUES
           (3,2)


SELECT p.[Name], c.[Name]
FROM dbo.Products p
LEFT JOIN dbo.ProductsCategories pd ON p.Id = pd.ProductId 
LEFT JOIN dbo.Categories c ON c.Id = pd.CategoryId