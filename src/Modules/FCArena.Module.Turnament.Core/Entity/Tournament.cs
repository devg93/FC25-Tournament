using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FCArena.Module.Turnament.Core.Entity
{
    public interface Tournament
    {
        public class Tournament
        {
            public int Id { get; set; }
            public string? Name { get; set; } // ტურნირის სახელი
            public string? GameType { get; set; } // თამაში (მაგ: FIFA, PES, ....)
            public TournamentFormat Format { get; set; } // ტურნირის ფორმატი (Round-Robin, Knockout)
            public decimal EntryFee { get; set; } // შესასვლელი თანხა (ბალანსიდან ჩამოჭრა)
            public int MaxPlayers { get; set; } // მაქსიმალური მოთამაშეები
            public DateTime StartDate { get; set; } // ტურნირის დაწყების დრო
            public DateTime EndDate { get; set; } // ტურნირის დასრულების დრო
            public TournamentStatus Status { get; set; } = TournamentStatus.Upcoming; // სტატუსი
            public List<TournamentRegistration> Registrations { get; set; } = new List<TournamentRegistration>(); // რეგისტრირებული მოთამაშეები
            public List<Match> Matches { get; set; } = new List<Match>(); // მატჩების სია
        }

        public enum TournamentFormat
        {
            RoundRobin, // ჯგუფური ეტაპი
            Knockout, // ნოკაუტი
            Hybrid // კომბინირებული ფორმატი
        }

        public enum TournamentStatus
        {
            Upcoming,
            Ongoing,
            Completed
        }
    }
}