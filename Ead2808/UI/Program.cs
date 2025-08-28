using Ead2808.Data;
using Ead2808.Service;

var ms = @"Server=localhost\SQLEXPRESS;Database=NomeDoDBAqui;Trusted_Connection=True;";

Db.ConnectionString = ms;

var service = new MatriculaService();
service.Executar();