﻿using Cifo.Model.GovFolder;

namespace Cifo.Service.Interfaces
{
    public interface IGovFolderService
    {
        Task<string?> ValidateCitizen(string citizenId);
        Task<CitizenDto> RegisterCitizen(CitizenDto citizen);
        Task<CitizenDto> UnregisterCitizen(CitizenDto citizenDto);
        Task<DocumentDto?> AuthenticateDocument(DocumentDto document);
    }
}
