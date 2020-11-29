using ProtoBuf.Serialization.Demo.Models;
using System;
using System.Collections.Generic;

namespace ProtoBuf.Serialization.Demo
{
    public static class TournamentHelper
    {
        private static List<Tournament> _tournaments;

        public static List<Tournament> Tournaments
        {
            get
            {
                _tournaments ??= GetExampleTournaments();
                return _tournaments;
            }
        }

        private static List<Tournament> GetExampleTournaments()
        {
            var tournaments = new List<Tournament>();

            for (int i = 0; i < 10000; i++)
            {
                tournaments.Add(new Tournament
                {
                    Id = i,
                    Name = Faker.Name.First(),
                    Players = Faker.RandomNumber.Next(1, 15),
                    MatchDate = DateTime.Now.AddDays(Faker.RandomNumber.Next(1, 365)),
                    Description = Faker.Lorem.Sentence()
                });
            }

            return tournaments;
        }
    }
}
