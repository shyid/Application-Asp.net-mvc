using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test3.Models
{
    public class Actor_Movie
    {
        public int MovieId {get;set;}
        public Movie movie {get;set;}
        public int ActorId {get;set;}
        public Actor actor {get;set;}


    }
}