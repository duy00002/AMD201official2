﻿using AMD201official2.Models;
using AutoMapper;

namespace AMD201official2.Mappings
{
	public class MappingProfiles: Profile
	{
		public MappingProfiles() 
		{
			CreateMap<Url, UrlDto>().ReverseMap();
		}
	}
}
