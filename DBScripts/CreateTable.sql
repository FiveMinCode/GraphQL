CREATE TABLE dbo.Book(    
    BookId int IDENTITY(1,1) NOT NULL,    
    Name varchar(100) NOT NULL,    
    Author varchar(100) NOT NULL,    
    ReleaseDate Date NULL  
 CONSTRAINT [PK_Book] PRIMARY KEY CLUSTERED     
(    
    BookId ASC    
)  
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]    
) ON [PRIMARY]  ;


CREATE TABLE dbo.Publisher(    
    PublisherId int IDENTITY(1,1) NOT NULL,    
    Name varchar(100) NOT NULL,    
    Email varchar(100) NOT NULL,    
    Phone varchar(20) NULL,  
 CONSTRAINT [PK_Participant] PRIMARY KEY CLUSTERED     
(    
    PublisherId ASC    
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]    
) ON [PRIMARY] ;

CREATE TABLE [dbo].BookPublishers  
(  
    BookPublisherId INT NOT NULL IDENTITY(1,1) ,  
        BookId INT NOT NULL,  
    PublisherId INT NULL,  
    CONSTRAINT [PK_BookPublishers] PRIMARY KEY CLUSTERED  
    (  
        BookPublisherId ASC  
    )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)   
    ON [PRIMARY]  
,CONSTRAINT [FK_BookPublishers_Book_BookId] FOREIGN KEY (BookId) REFERENCES [Book] (BookId)   
,CONSTRAINT [FK_BookPublishers_Publisher_PublisherId] FOREIGN KEY ([PublisherId]) REFERENCES [Publisher] ([PublisherId])   
) ON [PRIMARY];