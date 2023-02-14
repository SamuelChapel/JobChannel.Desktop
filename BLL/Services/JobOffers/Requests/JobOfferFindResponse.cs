﻿using Domain.Contracts;

namespace BLL.Services.JobOffers.Resquests;
public record JobOfferFindResponse(
        int Id,
        string Title,
        DateTime PublicationDate,
        string Url,
        string Salary,
        string Experience,
        string Company,
        int Id_Job,
        string Job,
        int Id_Contract,
        string Contract,
        int Id_City,
        string City,
        int Id_Department,
        string Department,
        int Id_Region,
        string Region
        ) : IResponse;
