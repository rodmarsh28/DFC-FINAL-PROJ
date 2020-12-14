﻿CREATE TABLE [dbo].[tblRFP] (
    [NO]        VARCHAR (255)   NOT NULL,
    [SRC]       VARCHAR (255)   NULL,
    [TRANSDATE] DATETIME2 (7)   NULL,
    [AMOUNT]    DECIMAL (20, 2) NULL,
    [USERID]    VARCHAR (255)   NULL,
    [STATUS]    VARCHAR (255)   NULL
);

