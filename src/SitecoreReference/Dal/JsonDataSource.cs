using System;
using System.Collections.Generic;
using System.Linq;
using SitecoreReference.Models;
using System.IO;
using Newtonsoft.Json;
using Microsoft.Extensions.PlatformAbstractions;

namespace SitecoreReference.Dal
{
    public class JsonDataSource : IDataSource
    {   
        private const string CLIENT_COMMENTS_FILE_PATH = "/Data/ClientComments.json";
        private const string TEAM_MEMBER_PROFILE_FILE_PATH = "/Data/TeamMemberProfiles.json";
        private const string SERVICES_FILE_PATH = "/Data/Services.json";
        private const string RECENT_WORK_FILE_PATH = "/Data/RecentWork.json";
        private const string LOCATIONS_FILE_PATH = "/Data/Locations.json";
        IApplicationEnvironment _appEnv;

        public JsonDataSource(IApplicationEnvironment appEnv)
        {
            _appEnv = appEnv;
        }

        public IEnumerable<ClientComment> GetAllClientComments()
        {
            var comments = new List<ClientComment>();
            var allText = File.ReadAllText(_appEnv.ApplicationBasePath + CLIENT_COMMENTS_FILE_PATH);
            comments = JsonConvert.DeserializeObject<List<ClientComment>>(allText);
           
            return comments;
        }

        public IEnumerable<Service> GetAllServices()
        {
            var services = new List<Service>();
            var allText = File.ReadAllText(_appEnv.ApplicationBasePath + SERVICES_FILE_PATH);
            services = JsonConvert.DeserializeObject<List<Service>>(allText);

            return services;
        }

        public IEnumerable<TeamMemberProfile> GetAllTeamMemberProfiles()
        {
            var profiles = new List<TeamMemberProfile>();
            var allText = File.ReadAllText(_appEnv.ApplicationBasePath + TEAM_MEMBER_PROFILE_FILE_PATH);
            profiles = JsonConvert.DeserializeObject<List<TeamMemberProfile>>(allText);

            return profiles;
        }

        public IEnumerable<RecentWork> GetAllRecentWork()
        {
            var recentWork = new List<RecentWork>();
            var allText = File.ReadAllText(_appEnv.ApplicationBasePath + RECENT_WORK_FILE_PATH);
            recentWork = JsonConvert.DeserializeObject<List<RecentWork>>(allText);

            return recentWork;
        }

        public IEnumerable<Location> GetAllLocations()
        {
            var locations = new List<Location>();
            var allText = File.ReadAllText(_appEnv.ApplicationBasePath + LOCATIONS_FILE_PATH);
            locations = JsonConvert.DeserializeObject<List<Location>>(allText);

            return locations;
        }
    }
}