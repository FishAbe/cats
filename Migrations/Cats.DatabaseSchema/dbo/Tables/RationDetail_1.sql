﻿CREATE TABLE [dbo].[RationDetail] (
    [RationDetailID] INT             IDENTITY (1, 1) NOT NULL,
    [RationID]       INT             NOT NULL,
    [CommodityID]    INT             NOT NULL,
    [Amount]         DECIMAL (18, 2) NOT NULL,
    [UnitID]         INT             NULL,
    CONSTRAINT [PK_Ration] PRIMARY KEY CLUSTERED ([RationDetailID] ASC),
    CONSTRAINT [FK_RationDetail_Commodity] FOREIGN KEY ([CommodityID]) REFERENCES [dbo].[Commodity] ([CommodityID]),
    CONSTRAINT [FK_RationDetail_Ration] FOREIGN KEY ([RationID]) REFERENCES [dbo].[Ration] ([RationID]),
    CONSTRAINT [FK_RationDetail_Unit] FOREIGN KEY ([UnitID]) REFERENCES [dbo].[Unit] ([UnitID])
);









