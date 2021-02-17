CREATE VIEW [dbo].[V_MovieInfo]
AS
SELECT        dbo.Movie.IdMovie, dbo.Movie.Title, dbo.Movie.Duration, dbo.Movie.Picture, dbo.Movie.Trailer, dbo.Movie.ReleaseDate, dbo.Movie.Summary, dbo.Movie.ShortDescription, dbo.MovieGenre.IdMovie AS Expr1, 
                         dbo.MovieGenre.IdGenre, dbo.Genre.IdGenre AS Expr2, dbo.Genre.Label, dbo.CrewMovie.IdMovie AS Expr3, dbo.CrewMovie.IdCrew, dbo.Crew.IdCrew AS Expr4, dbo.Crew.FirstName, dbo.Crew.LastName, dbo.Crew.Job, 
                         dbo.MovieCast.IdCast, dbo.MovieCast.idMovie AS Expr5, dbo.Cast.IdCast AS Expr6, dbo.Cast.FirstName AS Expr7, dbo.Cast.LastName AS Expr8
FROM            dbo.Movie LEFT OUTER JOIN
                         dbo.MovieGenre ON dbo.Movie.IdMovie = dbo.MovieGenre.IdMovie LEFT OUTER JOIN
                         dbo.Genre ON dbo.MovieGenre.IdGenre = dbo.Genre.IdGenre LEFT OUTER JOIN
                         dbo.CrewMovie ON dbo.Movie.IdMovie = dbo.CrewMovie.IdMovie LEFT OUTER JOIN
                         dbo.Crew ON dbo.CrewMovie.IdCrew = dbo.Crew.IdCrew LEFT OUTER JOIN
                         dbo.MovieCast ON dbo.Movie.IdMovie = dbo.MovieCast.idMovie LEFT OUTER JOIN
                         dbo.Cast ON dbo.MovieCast.IdCast = dbo.Cast.IdCast

GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Movie"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 246
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "MovieGenre"
            Begin Extent = 
               Top = 6
               Left = 284
               Bottom = 102
               Right = 492
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Genre"
            Begin Extent = 
               Top = 6
               Left = 530
               Bottom = 102
               Right = 738
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Crew"
            Begin Extent = 
               Top = 6
               Left = 776
               Bottom = 136
               Right = 984
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "CrewMovie"
            Begin Extent = 
               Top = 102
               Left = 284
               Bottom = 198
               Right = 492
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "MovieCast"
            Begin Extent = 
               Top = 102
               Left = 530
               Bottom = 198
               Right = 738
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Cast"
            Begin Extent = 
               Top = 138
               Left = 38
               Bottom = 251
               Right = 246
            End
            DisplayFlags = 280
     ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'V_MovieInfo';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'       TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'V_MovieInfo';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'V_MovieInfo';

