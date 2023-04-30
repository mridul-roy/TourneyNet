﻿using DAL.Interfaces;
using DAL.Model;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<Player,int,Player> PlayerData()
        {
            return new PlayerRepo();
        }


        public static IRepo<Fan, int, Fan> FanData()
        {
            return new FanRepo();
        }

        public static IRepo<FanPost, int, FanPost> FanPostData()
        {
            return new FanPostRepo();
        }

        public static IRepo<Payment, int, Payment> PaymentData()
        {
            return new PaymentRepo();
        }

        public static IRepo<Ranking, int, Ranking> RankingData()
        {
            return new RankingRepo();
        }

        public static IRepo<Tournament, int, Tournament> TournamentData()
        {
            return new TournamentRepo();
        }


    }
}
