using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr5
{
    public class Control_Club
    {
        View.ViewClub v_club;
        public Control_Club(View.ViewClub viewClub)
        {
            v_club = viewClub;
        }
        public void AddClub_Click()
        {
            Club clb = new Club();
            
            clb.NameClub = v_club.Name_cl;
            clb.Name_sponsor = v_club.Spon;
            clb.Nm_Coach = v_club.Coach;
            clb.Nm_Gum = v_club.Gum;

            clb.Type_car = v_club.Trans;
            clb.Year_create = v_club.Year_cr;
            clb.City = v_club.City;
            DB.AddClub(clb);
        }
        public void RenewClub_Click()
        {
            Club clb = new Club();
            clb.ID_club = v_club.ID_club;
            clb.NameClub = v_club.Name_cl;
            clb.Name_sponsor = v_club.Spon;
            clb.Nm_Coach = v_club.Coach;
            clb.Nm_Gum = v_club.Gum;

            clb.Type_car = v_club.Trans;
            clb.Year_create = v_club.Year_cr;
            clb.City = v_club.City;
            DB.RenewClub(clb);
        }
        public void DeleteClub_Click()
        {
            Club clb = new Club();
            clb.ID_club = v_club.ID_club;
            DB.DeleteClub(clb);
        }
    }
    public class Control_Coach
    {
        View.ViewCoach v_coach;
        public Control_Coach(View.ViewCoach viewCoach)
        {
            v_coach = viewCoach;
        }
        public void AddCoach_Click()
        {
            Coach ch = new Coach();
            ch.Lastname_tr = v_coach.Lastname_coach;
            ch.Firstname_tr = v_coach.Firstname;
            ch.Year_of_birth_tr = v_coach.Year_BD_coach;
            ch.Rank = v_coach.Rank;
            
            DB.AddCoach(ch);
        }
        public void RenewCoach_Click()
        {
            Coach ch = new Coach();
            ch.Lastname_tr = v_coach.Lastname_coach;
            ch.Firstname_tr = v_coach.Firstname;
            ch.Year_of_birth_tr = v_coach.Year_BD_coach;
            ch.Rank = v_coach.Rank;
            ch.idCoach = v_coach.ID_Coach;
            DB.RenewCoach(ch);
        }
        public void DeleteCoach_Click()
        {
            Coach ch = new Coach();
            ch.idCoach = v_coach.ID_Coach;
            DB.DeleteCoach(ch);
        }

    }
    public class Control_Games
    {
        View.ViewGames v_games;
        public Control_Games(View.ViewGames viewGames)
        {
            v_games = viewGames;
        }
        public void AddGames_Click() 
        {
            Games gm = new Games();
            gm.ID_Match = v_games.ID_Match;
            gm.Match = v_games.Match;
            gm.N_cl = v_games.Clb;
            DB.AddGames(gm);
            
        }
        public void RenewGames_Click() 
        {
            Games gm = new Games();
            gm.ID_Match = v_games.ID_Match;
            gm.Match = v_games.Match;
            DB.RenewGames(gm);
        }
        public void DeleteGames_Click() 
        {
            Games gm = new Games();
            gm.ID_Match = v_games.ID_Match;
            
            DB.DeleteGames(gm);
        }
        public void Add_M_has_cl()
        {
            Games gm = new Games();
            gm.ID_Match = v_games.ID_Match;
            gm.Match = v_games.Match;
            gm.N_cl = v_games.Clb;
            DB.AddGms_clb(gm);
        }
        public void Ren_M_has_cl()
        {
            Games gm = new Games();
            gm.ID_Match = v_games.ID_Match;
            gm.Match = v_games.Match;
            gm.N_cl = v_games.Clb;
            DB.RenewGms_clb(gm);
        }
        public void Del_M_has_cl()
        {
            Games gm = new Games();
            gm.ID_Match = v_games.ID_Match;
            gm.Match = v_games.Match;
            gm.N_cl = v_games.Clb;
            DB.DeleteGms_clb(gm);
        }

    }
    public class Control_Gum
    {
        View.ViewGum v_gum;
        public Control_Gum(View.ViewGum viewGum)
        {
            v_gum = viewGum;
        }
        public void AddGum_Click()
        {
            Gum gum = new Gum();
            gum.Name_gum = v_gum.Name_gum;
            gum.Address = v_gum.Address;
            gum.Capacity = v_gum.Capacity_gm;
            gum.Phone_number = v_gum.Phone_num;
            gum.Category = v_gum.Category_gm;
            
            DB.AddGum(gum);
        }
        public void RenewGum_Click()
        {
            Gum gm = new Gum();
            gm.Name_gum = v_gum.Name_gum;
            gm.Address = v_gum.Address;
            gm.Capacity = v_gum.Capacity_gm;
            gm.Phone_number = v_gum.Phone_num;
            gm.Category = v_gum.Category_gm;
            gm.idGum = v_gum.ID_gum;
            DB.RenewGum(gm);
        }
        public void DeleteGum_Click()
        {
            Gum gm = new Gum();
            gm.idGum = v_gum.ID_gum;
            DB.DeleteGum(gm);
        }
    }
    public class Control_Sponsor
    {
        View.ViewSponsor v_sponsor;
        public Control_Sponsor(View.ViewSponsor viewSponsor)
        {
            v_sponsor = viewSponsor;
        }
        public void AddSponsor_Click()
        {
            Sponsor spon = new Sponsor();
            spon.Name_sponsor = v_sponsor.Name_spon;
            
            DB.AddSponsor(spon);
        }
        public void RenewSponsor_Click()
        {
            Sponsor spon = new Sponsor();
            spon.Name_sponsor = v_sponsor.Name_spon;
            spon.ID_spon = v_sponsor.ID_Spon;
            DB.RenewSponsor(spon);
        }
        public void DeleteSonsor_Click()
        {
            Sponsor spon = new Sponsor();
            
            spon.ID_spon = v_sponsor.ID_Spon;
            DB.DeleteSponsor(spon);
        }
    }
    public class Control_Sportsmen
    {
        View.ViewSportsmen v_sportsmen;
        public Control_Sportsmen(View.ViewSportsmen viewSportsmen)
        {
            v_sportsmen = viewSportsmen;
        }
        public void AddSportsmen_Click()
        {
            Sportsmen sport = new Sportsmen();
            
            sport.Lastname_sp = v_sportsmen.Lastname_sp;
            sport.Firstname_sp = v_sportsmen.Firstname_sp;
            sport.Role = v_sportsmen.Role;
            sport.Year_of_birth_sp = v_sportsmen.Year_BD_sp;
            sport.Height = v_sportsmen.Hght;
            sport.Weight = v_sportsmen.Weight;
            sport.Data_hw = v_sportsmen.Data_hw;
            sport.Number = v_sportsmen.Number;
            sport.Club = v_sportsmen.Club;
            DB.AddSportsmen(sport);
        }
        public void RenewSportsmen_Click()
        {
            Sportsmen sport = new Sportsmen();
            sport.id_Sportsmen = v_sportsmen.ID_sport;
            sport.Lastname_sp = v_sportsmen.Lastname_sp;
            sport.Firstname_sp = v_sportsmen.Firstname_sp;
            sport.Role = v_sportsmen.Role;
            sport.Year_of_birth_sp = v_sportsmen.Year_BD_sp;
            sport.Height = v_sportsmen.Hght;
            sport.Weight = v_sportsmen.Weight;
            sport.Data_hw = v_sportsmen.Data_hw;
            sport.Number = v_sportsmen.Number;
            sport.Club = v_sportsmen.Club;
            DB.RenewSportsmen(sport);
        }
        public void DeleteSportsmen_Click()
        {
            Sportsmen sport = new Sportsmen();
            sport.id_Sportsmen = v_sportsmen.ID_sport;
            DB.DeleteSportsmen(sport);
        }
    }
    public class Control_Transport
    {
        View.ViewTransport v_transport;
        public Control_Transport(View.ViewTransport viewTransport)
        {
            v_transport = viewTransport;
        }
        public void AddTransport_Click()
        {
            Transport tr = new Transport();
            tr.Type = v_transport.Type_tr;
            tr.Capacity_tr = v_transport.Capacity_tr;
            
            DB.AddTransport(tr);
        }
        public void RenewTransport_Click()
        {
            Transport tr = new Transport();
            tr.Type = v_transport.Type_tr;
            tr.Capacity_tr = v_transport.Capacity_tr;
            tr.ID_transport = v_transport.ID_tr;
            DB.RenewTransport(tr);
        }
        public void DeleteTransport_Click()
        {
            Transport tr = new Transport();
            tr.ID_transport = v_transport.ID_tr;
            DB.DeleteTransport(tr);
        }
    }
}
