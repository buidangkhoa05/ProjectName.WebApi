﻿using AutoAid.Domain.Common;
using AutoAid.Domain.Common.PagedList;
using AutoAid.Domain.Dto.Place;

namespace ProjectName.Application.Service
{
    public interface IPlaceService : IDisposable
    {
        Task<bool> Create(CreatePlaceDto createData);
        Task<IPagedList<PlaceDto>> SearchPlace(string keySearch, PagingQuery paginQuery, string orderbyString);
    }
}
