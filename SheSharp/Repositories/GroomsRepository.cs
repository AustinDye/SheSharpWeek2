using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using SheSharp.Models;


namespace SheSharp.Repositories
{

 public class GroomsRepository
 {
  private readonly IDbConnection _db;

  public GroomsRepository(IDbConnection db)
  {
   _db = db;
  }

  internal Groom Create(Groom groomData)
  {
   string sql = @"
       INSERT INTO groom
       (name, startTime, endTime, groomLocation, size, price, tip, creatorId, breed, services)
       VALUES
       (@Name, @StartTime, @EndTime, @GroomLocation, @Size, @Price, @Tip, @CreatorId, @Breed, @Services);
       SELECT LAST_INSERT_ID();
      ";
   groomData.Id = _db.ExecuteScalar<int>(sql, groomData);
   return groomData;
  }

  internal List<Groom> Get()
  {
   string sql = @"
       SELECT
       g.*,
       act.*
       FROM groom g
       JOIN accounts act ON g.creatorId = act.id;
       ";
   return _db.Query<Groom, Account, Groom>(sql, (groom, account) =>
{
 groom.Creator = account;
 return groom;
}).ToList();
  }

    internal Groom Get(int id)
  {
   string sql = @"
    SELECT
      g.*,
      act.*
      FROM groom g
      JOIN accounts act ON a.creatorId = act.Id
      WHERE g.id = @id
    ";
   return _db.Query<Groom, Account, Groom>(sql, (groom, account) =>
   {
    groom.Creator = account;
    return groom;
   }, new { id }).FirstOrDefault();
  }

  internal void Edit(Groom original)
  {
   string sql = @"
      UPDATE groom
      SET
        name = @Name,
        startTime = @StartTime,
        endTime = @EndTime,
        groomLocation = @GroomLocation,
        size = @Size,
        price = @Price,
        tip = @Tip
        breed = @Breed
        services = @Services
       WHERE id = @Id 
       ";
   _db.Execute(sql, original);
  }

  internal void Delete(int id)
  {
   string sql = "DELETE FROM groom WHERE id = @id LIMIT 1";
      _db.Execute(sql, new { id });
  }
 }
}