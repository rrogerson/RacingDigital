using RacingDigital.Models;
using RacingDigital.Services.Interfaces;
using System.Data.SqlClient;
using Dapper;
using System.Data;


namespace RacingDigital.Services
{
    public class RacesService : IRacesService
    {
        private const string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ruth_\\source\\repos\\RacingDigital\\RacingDigital.Services\\RacingDigitalDatabase.mdf;Integrated Security=True";


        public IEnumerable<RaceResult> GetRaces()
        {
       
            using var connection = new SqlConnection(connectionString);
            connection.Open();
            var races = connection.Query<RaceResult>("SELECT * FROM dbo.Races");


            return races;
           
        }

        public IEnumerable<Notes> GetNotes(int raceId) {

            using var connection = new SqlConnection(connectionString);
            connection.Open();
            return connection.Query<Notes>($"SELECT * FROM dbo.Notes WHERE raceId = {raceId}");
          }

        public int AddNotes(Notes item)
        {
            var sql = "INSERT INTO Notes (RaceID, NoteText) VALUES (@RaceID, @NoteText)";
            using var connection = new SqlConnection(connectionString);
            connection.Open();
            return connection.Execute(sql, new { item.RaceId, item.NoteText }, commandType: CommandType.Text);
       }

    }
}
