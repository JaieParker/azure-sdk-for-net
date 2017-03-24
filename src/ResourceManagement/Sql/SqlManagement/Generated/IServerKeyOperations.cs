// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.Sql.Models;

namespace Microsoft.Azure.Management.Sql
{
    /// <summary>
    /// Represents all the operations of Azure SQL Database that interact with
    /// Azure Key Vault Server Keys. Contains operations to: Add, Delete, and
    /// Retrieve Server Ke.
    /// </summary>
    public partial interface IServerKeyOperations
    {
        /// <summary>
        /// Begins creating a new Azure SQL Server Key or updating an existing
        /// Azure SQL Server Key. To determine the status of the operation
        /// call GetCreateOrUpdateOperationStatus.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Resource Group to which the server belongs.
        /// </param>
        /// <param name='serverName'>
        /// The name of the Azure SQL Server to which to add the Server Key.
        /// </param>
        /// <param name='keyName'>
        /// The name of the Azure SQL Server Key.
        /// </param>
        /// <param name='parameters'>
        /// The required parameters for createing or updating a Server Key.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Represents the response to a Azure Sql Server Key operation request.
        /// </returns>
        Task<ServerKeyCreateOrUpdateResponse> BeginCreateOrUpdateAsync(string resourceGroupName, string serverName, string keyName, ServerKeyCreateOrUpdateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Begins deleting an existing Azure SQL Server Key.To determine the
        /// status of the operation call GetDeleteOperationStatus.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Resource Group to which the server belongs.
        /// </param>
        /// <param name='serverName'>
        /// The name of the Azure SQL Server to which the Azure SQL Server Key
        /// belongs
        /// </param>
        /// <param name='keyName'>
        /// The name of the Azure SQL Server Key.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Represents the response to an Azure Sql Server Key Delete request.
        /// </returns>
        Task<ServerKeyDeleteResponse> BeginDeleteAsync(string resourceGroupName, string serverName, string keyName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Creates a new Azure SQL Server Key or updates an existing Azure SQL
        /// Server Key.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Resource Group to which the server belongs.
        /// </param>
        /// <param name='serverName'>
        /// The name of the Azure SQL Server to which to add the Server Key.
        /// </param>
        /// <param name='keyName'>
        /// The name of the Azure SQL Server Key.
        /// </param>
        /// <param name='parameters'>
        /// The required parameters for createing or updating a Server Key.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Represents the response to a Azure Sql Server Key operation request.
        /// </returns>
        Task<ServerKeyCreateOrUpdateResponse> CreateOrUpdateAsync(string resourceGroupName, string serverName, string keyName, ServerKeyCreateOrUpdateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Deletes an existing Azure SQL Server Key.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Resource Group to which the server belongs.
        /// </param>
        /// <param name='serverName'>
        /// The name of the Azure SQL Server to which the Azure SQL Server Key
        /// belongs
        /// </param>
        /// <param name='keyName'>
        /// The name of the Azure SQL Server Key to be deleted.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Represents the response to an Azure Sql Server Key Delete request.
        /// </returns>
        Task<ServerKeyDeleteResponse> DeleteAsync(string resourceGroupName, string serverName, string keyName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets an Azure Sql Server Key.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Resource Group to which the server belongs.
        /// </param>
        /// <param name='serverName'>
        /// The name of the Azure SQL Database Server that has the key.
        /// </param>
        /// <param name='keyName'>
        /// The name of the Azure Key Vault Key to be retrieved from the Azure
        /// SQL Database Server.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Represents the response to a List Azure Sql Server Key request.
        /// </returns>
        Task<ServerKeyGetResponse> GetAsync(string resourceGroupName, string serverName, string keyName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the status of an Azure SQL Server Key create or update
        /// operation.
        /// </summary>
        /// <param name='operationStatusLink'>
        /// Location value returned by the Begin operation
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Represents the response to a Azure Sql Server Key operation request.
        /// </returns>
        Task<ServerKeyCreateOrUpdateResponse> GetCreateOrUpdateOperationStatusAsync(string operationStatusLink, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the status of an Azure SQL Server Key delete operation.
        /// </summary>
        /// <param name='operationStatusLink'>
        /// Location value returned by the Begin operation
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Represents the response to an Azure Sql Server Key Delete request.
        /// </returns>
        Task<ServerKeyDeleteResponse> GetDeleteOperationStatusAsync(string operationStatusLink, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets all Azure SQL Database Server Keys for a server.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Resource Group to which the server belongs.
        /// </param>
        /// <param name='serverName'>
        /// The name of the Azure SQL Database Server.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Represents the response to a List Azure Sql Server Key request.
        /// </returns>
        Task<ServerKeyListResponse> ListAsync(string resourceGroupName, string serverName, CancellationToken cancellationToken);
    }
}