﻿using Abp.Application.Services.Dto;

namespace Travelmatics.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

