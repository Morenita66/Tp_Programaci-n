using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entity_library;


namespace dao_library
{
    public class TeamDAO
    {
        public Team CreateTeam(Team team)
        {
            MockDatabase.Teams.Add(team);
            return team;
        }

        public Team? ReadTeamById(long id)
        {
            return MockDatabase.Teams.FirstOrDefault(t => t.Id == id);
        }

        public List<Team> ReadTeams()
        {
            return MockDatabase.Teams;
        }

        public bool UpdateTeam(Team updatedTeam)
        {
            var existingTeam = ReadTeamById(updatedTeam.Id);

            if (existingTeam != null)
            {
                existingTeam.Name = updatedTeam.Name;
                existingTeam.Category = updatedTeam.Category;
                existingTeam.Players = updatedTeam.Players;
                existingTeam.Trainers = updatedTeam.Trainers;

                return true;
            }

            return false;
        }

        public bool DeleteTeam(long id)
        {
            var teamToDelete = ReadTeamById(id);

            if (teamToDelete != null)
            {
                MockDatabase.Teams.Remove(teamToDelete);
                return true;
            }

            return false;
        }
    }
}
