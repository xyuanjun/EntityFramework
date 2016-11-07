//// Copyright (c) .NET Foundation. All rights reserved.
//// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace Microsoft.EntityFrameworkCore.Specification.Tests.TestModels.GearsOfWarModel
//{
//    public static partial class GearsOfWarData
//    {
//        private static readonly City[] _cities;
//        private static readonly CogTag[] _cogTags;
//        private static readonly Gear[] _gears;
//        private static readonly Mission[] _missions;
//        private static readonly Squad[] _squads;
//        private static readonly SquadMission[] _squadMissions;
//        private static readonly Weapon[] _weapons;

//        static GearsOfWarData()
//        {


//        }

//        public Squad[] CreateSquads =>
//            new Squad[]
//            {
//                new Squad { Name = "Delta",  }
//            }


//        public Gear[] CreateGears =>
//            new Gear[]
//            {
//                new Gear
//                {

//                }
//            }


//        public static IQueryable<T> Set<T>()
//        {
//            if (typeof(T) == typeof(City))
//            {
//                return new List<T>(_cities.Cast<T>()).AsQueryable();
//            }

//            if (typeof(T) == typeof(CogTag))
//            {
//                return new List<T>(_cogTags.Cast<T>()).AsQueryable();
//            }

//            if (typeof(T) == typeof(Gear))
//            {
//                return new List<T>(_gears.Cast<T>()).AsQueryable();
//            }

//            if (typeof(T) == typeof(Mission))
//            {
//                return new List<T>(_missions.Cast<T>()).AsQueryable();
//            }

//            if (typeof(T) == typeof(Squad))
//            {
//                return new List<T>(_squads.Cast<T>()).AsQueryable();
//            }

//            if (typeof(T) == typeof(SquadMission))
//            {
//                return new List<T>(_squadMissions.Cast<T>()).AsQueryable();
//            }

//            if (typeof(T) == typeof(Weapon))
//            {
//                return new List<T>(_weapons.Cast<T>()).AsQueryable();
//            }

//            throw new NotImplementedException();
//        }
//    }
//}
