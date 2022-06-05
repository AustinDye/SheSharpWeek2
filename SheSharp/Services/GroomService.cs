using SheSharp.Models;
using SheSharp.Repositories;
using System.Collections.Generic;
using System;

namespace SheSharp.Services
{
 public class GroomService
 {
  private readonly GroomsRepository _repo;

  public GroomService(GroomsRepository repo)
  {
   _repo = repo;
  }

  internal List<Groom> Get()
  {
   return _repo.Get();
  }

   internal Groom Create(Groom groomData)
    {
      return _repo.Create(groomData);
    }

    internal Groom Get(int id)
    {
      Groom groom = _repo.Get(id);
      if (groom == null)
      {
        throw new Exception("Invalid groom");
      }
      return groom;
    }

    internal Groom Edit(Groom groomData)
    {
      Groom original = Get(groomData.Id);
      if (original.CreatorId != groomData.CreatorId)
      {
        throw new Exception("You cant do that!");
      }
      original.Name = groomData.Name ?? original.Name;
      original.StartTime = groomData.StartTime ?? original.StartTime;
      original.EndTime = groomData.EndTime ?? original.EndTime;
      original.groomLocation = groomData.groomLocation ?? original.groomLocation;
      original.Size = groomData.Size;
      original.Price = groomData.Price;
      original.Tip = groomData.Tip;
      original.Breed = groomData.Breed;
      original.Services = groomData.Services;

   _repo.Edit(original);

   return Get(original.Id);
  }
 }
}