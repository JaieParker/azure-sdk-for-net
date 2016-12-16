// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.AppService.Fluent
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// AppServiceCertificateOrdersOperations operations.
    /// </summary>
    public partial interface IAppServiceCertificateOrdersOperations
    {
        /// <summary>
        /// List all certificate orders in a subscription.
        /// </summary>
        /// <remarks>
        /// List all certificate orders in a subscription.
        /// </remarks>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<AppServiceCertificateOrderInner>>> ListWithHttpMessagesAsync(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Validate information for a certificate order.
        /// </summary>
        /// <remarks>
        /// Validate information for a certificate order.
        /// </remarks>
        /// <param name='appServiceCertificateOrder'>
        /// Information for a certificate order.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse> ValidatePurchaseInformationWithHttpMessagesAsync(AppServiceCertificateOrderInner appServiceCertificateOrder, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get certificate orders in a resource group.
        /// </summary>
        /// <remarks>
        /// Get certificate orders in a resource group.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of the resource group to which the resource belongs.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<AppServiceCertificateOrderInner>>> ListByResourceGroupWithHttpMessagesAsync(string resourceGroupName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// List all certificates associated with a certificate order.
        /// </summary>
        /// <remarks>
        /// List all certificates associated with a certificate order.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of the resource group to which the resource belongs.
        /// </param>
        /// <param name='certificateOrderName'>
        /// Name of the certificate order.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<AppServiceCertificateInner>>> ListCertificatesWithHttpMessagesAsync(string resourceGroupName, string certificateOrderName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get the certificate associated with a certificate order.
        /// </summary>
        /// <remarks>
        /// Get the certificate associated with a certificate order.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of the resource group to which the resource belongs.
        /// </param>
        /// <param name='certificateOrderName'>
        /// Name of the certificate order.
        /// </param>
        /// <param name='name'>
        /// Name of the certificate.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<AppServiceCertificateInner>> GetCertificateWithHttpMessagesAsync(string resourceGroupName, string certificateOrderName, string name, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Creates or updates a certificate and associates with key vault
        /// secret.
        /// </summary>
        /// <remarks>
        /// Creates or updates a certificate and associates with key vault
        /// secret.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of the resource group to which the resource belongs.
        /// </param>
        /// <param name='certificateOrderName'>
        /// Name of the certificate order.
        /// </param>
        /// <param name='name'>
        /// Name of the certificate.
        /// </param>
        /// <param name='keyVaultCertificate'>
        /// Key vault certificate resource Id.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<AppServiceCertificateInner>> CreateOrUpdateCertificateWithHttpMessagesAsync(string resourceGroupName, string certificateOrderName, string name, AppServiceCertificateInner keyVaultCertificate, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Creates or updates a certificate and associates with key vault
        /// secret.
        /// </summary>
        /// <remarks>
        /// Creates or updates a certificate and associates with key vault
        /// secret.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of the resource group to which the resource belongs.
        /// </param>
        /// <param name='certificateOrderName'>
        /// Name of the certificate order.
        /// </param>
        /// <param name='name'>
        /// Name of the certificate.
        /// </param>
        /// <param name='keyVaultCertificate'>
        /// Key vault certificate resource Id.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<AppServiceCertificateInner>> BeginCreateOrUpdateCertificateWithHttpMessagesAsync(string resourceGroupName, string certificateOrderName, string name, AppServiceCertificateInner keyVaultCertificate, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Delete the certificate associated with a certificate order.
        /// </summary>
        /// <remarks>
        /// Delete the certificate associated with a certificate order.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of the resource group to which the resource belongs.
        /// </param>
        /// <param name='certificateOrderName'>
        /// Name of the certificate order.
        /// </param>
        /// <param name='name'>
        /// Name of the certificate.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse> DeleteCertificateWithHttpMessagesAsync(string resourceGroupName, string certificateOrderName, string name, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get a certificate order.
        /// </summary>
        /// <remarks>
        /// Get a certificate order.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of the resource group to which the resource belongs.
        /// </param>
        /// <param name='name'>
        /// Name of the certificate.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<AppServiceCertificateOrderInner>> GetWithHttpMessagesAsync(string resourceGroupName, string name, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Create or update a certificate purchase order.
        /// </summary>
        /// <remarks>
        /// Create or update a certificate purchase order.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of the resource group to which the resource belongs.
        /// </param>
        /// <param name='name'>
        /// Name of the certificate.
        /// </param>
        /// <param name='certificateDistinguishedName'>
        /// Distinguished name to to use for the certificate order.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<AppServiceCertificateOrderInner>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string name, AppServiceCertificateOrderInner certificateDistinguishedName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Create or update a certificate purchase order.
        /// </summary>
        /// <remarks>
        /// Create or update a certificate purchase order.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of the resource group to which the resource belongs.
        /// </param>
        /// <param name='name'>
        /// Name of the certificate.
        /// </param>
        /// <param name='certificateDistinguishedName'>
        /// Distinguished name to to use for the certificate order.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<AppServiceCertificateOrderInner>> BeginCreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string name, AppServiceCertificateOrderInner certificateDistinguishedName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Delete an existing certificate order.
        /// </summary>
        /// <remarks>
        /// Delete an existing certificate order.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of the resource group to which the resource belongs.
        /// </param>
        /// <param name='name'>
        /// Name of the certificate.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse> DeleteCertificateOrderWithHttpMessagesAsync(string resourceGroupName, string name, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Reissue an existing certificate order.
        /// </summary>
        /// <remarks>
        /// Reissue an existing certificate order.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of the resource group to which the resource belongs.
        /// </param>
        /// <param name='name'>
        /// Name of the certificate.
        /// </param>
        /// <param name='reissueCertificateOrderRequest'>
        /// Parameters for the reissue.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse> ReissueWithHttpMessagesAsync(string resourceGroupName, string name, ReissueCertificateOrderRequestInner reissueCertificateOrderRequest, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Renew an existing certificate order.
        /// </summary>
        /// <remarks>
        /// Renew an existing certificate order.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of the resource group to which the resource belongs.
        /// </param>
        /// <param name='name'>
        /// Certificate name
        /// </param>
        /// <param name='renewCertificateOrderRequest'>
        /// Renew parameters
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse> RenewWithHttpMessagesAsync(string resourceGroupName, string name, RenewCertificateOrderRequestInner renewCertificateOrderRequest, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Resend certificate email.
        /// </summary>
        /// <remarks>
        /// Resend certificate email.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of the resource group to which the resource belongs.
        /// </param>
        /// <param name='name'>
        /// Certificate order name
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse> ResendEmailWithHttpMessagesAsync(string resourceGroupName, string name, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Retrieve the list of certificate actions.
        /// </summary>
        /// <remarks>
        /// Retrieve the list of certificate actions.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of the resource group to which the resource belongs.
        /// </param>
        /// <param name='name'>
        /// Certificate order name
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<System.Collections.Generic.IList<CertificateOrderActionInner>>> RetrieveCertificateActionsWithHttpMessagesAsync(string resourceGroupName, string name, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Retrieve email history.
        /// </summary>
        /// <remarks>
        /// Retrieve email history.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of the resource group to which the resource belongs.
        /// </param>
        /// <param name='name'>
        /// Certificate order name
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<System.Collections.Generic.IList<CertificateEmailInner>>> RetrieveCertificateEmailHistoryWithHttpMessagesAsync(string resourceGroupName, string name, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Verify domain ownership for this certificate order.
        /// </summary>
        /// <remarks>
        /// Verify domain ownership for this certificate order.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of the resource group to which the resource belongs.
        /// </param>
        /// <param name='name'>
        /// Certificate order name
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse> VerifyDomainOwnershipWithHttpMessagesAsync(string resourceGroupName, string name, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// List all certificate orders in a subscription.
        /// </summary>
        /// <remarks>
        /// List all certificate orders in a subscription.
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<AppServiceCertificateOrderInner>>> ListNextWithHttpMessagesAsync(string nextPageLink, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get certificate orders in a resource group.
        /// </summary>
        /// <remarks>
        /// Get certificate orders in a resource group.
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<AppServiceCertificateOrderInner>>> ListByResourceGroupNextWithHttpMessagesAsync(string nextPageLink, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// List all certificates associated with a certificate order.
        /// </summary>
        /// <remarks>
        /// List all certificates associated with a certificate order.
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<AppServiceCertificateInner>>> ListCertificatesNextWithHttpMessagesAsync(string nextPageLink, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    }
}
