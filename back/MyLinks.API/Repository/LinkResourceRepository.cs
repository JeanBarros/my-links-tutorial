using System;
using System.Collections.Generic;
using MyLinks.Domain;
using MyLinks.Domain.Repository;

namespace MyLinks.API.Repository
{
    public class LinkResourceRepository : ILinkResourceRepository{
        public void Save(LinkResource domain)
        {}

        public LinkResource GetById(Guid id)
        {
            return new LinkResource{
                Id = Guid.NewGuid(),
                Title = "Site",
                URL = "https://www.google.com"
            };
        }

        public void DeleteById(Guid id)
        {}

        public ICollection<LinkResource> GetAll()
        {
            List<LinkResource> linkResources = new List<LinkResource>();

            linkResources.Add(new LinkResource{
                Id = Guid.NewGuid(),
                Title = "Site",
                URL = "https://www.google.com"
            });

            linkResources.Add(new LinkResource{
                Id = Guid.NewGuid(),
                Title = "Canal youtube",
                URL = "https://youtube.com"
            });

            return linkResources;
        }
    }
}