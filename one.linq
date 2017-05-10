<Query Kind="Statements">
  <Connection>
    <ID>f2c9b130-0bda-4a68-b71e-52317540032a</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from m in MediaTypes
			  select new{
			  	Name = m.Name,
				Tracks = from t in m.Tracks
						 select new{
						 	TrackName = t.Name,
							Album = t.Album,
							Genre = t.Genre,
							AlbumTitle = t.Album.Title,
							GenreId = t.Genre.Name,
							Artist = t.Album.Artist.ArtistId,							
							ReleaseYear = t.Album.ReleaseYear,
							ReleaseLabel= t.Album.ReleaseLabel

						 }
			  };
results.Dump();