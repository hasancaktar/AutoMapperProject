using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Entites.Concrete;
using Entites.Dto;

namespace Entites
{
    public class UserProfile : User
    {
        
        public UserProfile()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<User, UserProfile>().
                    ForMember(x=>x.FirstName, y=>y.MapFrom(s=>s.FirstName+" "+s.LastName)).
                    ForMember(d=>d.Status, x=>x.MapFrom(s=>((StatusCode)s.Status).ToString()));
            });
            IMapper mapper = config.CreateMapper();
            var source = new User();
            var dest = mapper.Map<User, UserProfile>(source);
        }
    }
}
