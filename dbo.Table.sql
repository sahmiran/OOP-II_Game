CREATE TABLE [dbo].Admins (
    [username]    VARCHAR (20)  NOT NULL,
    [password]    VARCHAR (20)  NOT NULL,
    [fullname]    VARCHAR (200) NOT NULL,
    [phonenumber] VARCHAR (11)  NULL,
    [address]     VARCHAR (400) NULL,
    [city]        VARCHAR (50)  NULL,
    [country]     VARCHAR (50)  NULL,
    [email]       VARCHAR (100) NOT NULL,
    PRIMARY KEY CLUSTERED ([username] ASC)
);

