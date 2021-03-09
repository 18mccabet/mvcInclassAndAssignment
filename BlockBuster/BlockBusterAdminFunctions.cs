using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using BlockBuster.Models;
using Microsoft.EntityFrameworkCore;


namespace BlockBuster
{
    public class BlockBusterAdminFunctions
    {
        public static void AddMovie(Movie movie)
        {
            try
            {
                using (var db = new SE407_BlockBusterContext())
                {
                    db.Movies.Add(movie);
                    db.SaveChanges();
                }
            } catch (Exception e)
            {

            }
        }
        public static void DeleteMovie(int id)
        {
            try
            {
                using (var db = new SE407_BlockBusterContext())
                {
                    var movieToDelete = db.Movies.Find(id);
                    db.Movies.Remove(movieToDelete);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {

            }
        }
        public static void EditMovie(Movie movie)
        {
            try
            {
                using (var db = new SE407_BlockBusterContext())
                {
                    db.Movies.Update(movie);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {

            }
        }
    }
}
