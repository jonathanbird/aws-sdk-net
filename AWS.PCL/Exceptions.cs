using System;

namespace AWS.PCL
{
	public interface IShouldIgnoreAndRetry
	{
	}

	public interface IShouldRefreshCredentials
	{
	}

	public class DataProviderException : Exception
	{
		public DataProviderException (string message, Exception innerException) : base (message, innerException)
		{	
		}
	}
	// The conditional request failed.	Example: The expected value did not match what was stored in the system.
	public class ConditionalCheckFailedException : DataProviderException
	{
		public ConditionalCheckFailedException (string message, Exception innerException) : base (message, innerException)
		{
		}
	}
	// The resource which is being requested does not exist.	Example: Table which is being requested does not exist, or is too early in the CREATING state.
	public class ResourceNotFoundException : DataProviderException, IShouldRefreshCredentials
	{
		public ResourceNotFoundException (string message, Exception innerException) : base (message, innerException)
		{

		}
	}
	// One or more required parameter values were missing.	One or more required parameter values were missing.
	public class ValidationException : DataProviderException
	{
		public ValidationException (string message, Exception innerException) : base (message, innerException)
		{

		}
	}
	#region UseLimitedException
	public abstract class UseLimitedException : DataProviderException, IShouldIgnoreAndRetry
	{
		public UseLimitedException (string message, Exception innerException) : base (message, innerException)
		{
			
		}
	}

	public class ItemCollectionSizeLimitExceededException : UseLimitedException
	{
		public ItemCollectionSizeLimitExceededException (string message, Exception innerException) : base (message, innerException)
		{

		}
	}
	// Too many operations for a given subscriber.	Example: The number of concurrent table requests (cumulative number of tables in the CREATING, DELETING or UPDATING state) exceeds the maximum allowed of 20. The total limit of tables (currently in the ACTIVE state) is 250.
	public class LimitExceededException : UseLimitedException
	{
		public LimitExceededException (string message, Exception innerException) : base (message, innerException)
		{

		}
	}
	// You exceeded your maximum allowed provisioned throughput.	Example: Your request rate is too high or the request is too large. The AWS SDKs for DynamoDB automatically retry requests that receive this exception. So, your request is eventually successful, unless the request is too large or your retry queue is too large to finish. Reduce the frequency of requests, using Error Retries and Exponential Backoff. Or, see Specifying Read and Write Requirements for Tables for other strategies.
	public class ProvisionedThroughputExceededException : UseLimitedException
	{
		public ProvisionedThroughputExceededException (string message, Exception innerException) : base (message, innerException)
		{

		}
	}
	// Rate of requests exceeds the allowed throughput.	This can be returned by the control plane API (CreateTable, DescribeTable, etc) when they are requested too rapidly.
	public class ThrottlingException : UseLimitedException
	{
		public ThrottlingException (string message, Exception innerException) : base (message, innerException)
		{

		}
	}
	// The resource which you are attempting to change is in use.	Example: You tried to recreate an existing table, or delete a table currently in the CREATING state.
	public class ResourceInUseException : DataProviderException
	{
		public ResourceInUseException (string message, Exception innerException) : base (message, innerException)
		{

		}
	}
	#endregion
	#region AuthenticationFailureException
	public abstract class AuthenticationFailureException : DataProviderException, IShouldRefreshCredentials
	{
		public AuthenticationFailureException (string message, Exception innerException) : base (message, innerException)
		{
			
		}
	}
	// Access denied.	General authentication failure. The client did not correctly sign the request. Consult the signing documentation.
	public class AccessDeniedException : AuthenticationFailureException
	{
		public AccessDeniedException (string message, Exception innerException) : base (message, innerException)
		{

		}
	}
	// The request signature does not conform to AWS standards.	The signature in the request did not include all of the required components. See HTTP Header Contents.
	public class IncompleteSignatureException : AuthenticationFailureException
	{
		public IncompleteSignatureException (string message, Exception innerException) : base (message, innerException)
		{

		}
	}
	//  Request must contain a valid (registered) AWS Access Key ID.	The request did not include the required x-amz-security-token. See Making HTTP Requests to DynamoDB.
	public class MissingAuthenticationTokenException : AuthenticationFailureException
	{
		public MissingAuthenticationTokenException (string message, Exception innerException) : base (message, innerException)
		{

		}
	}
	// The Access Key ID or security token is invalid.	The request signature is incorrect. The most likely cause is an invalid AWS access key ID or secret key.
	public class UnrecognizedClientException : AuthenticationFailureException
	{
		public UnrecognizedClientException (string message, Exception innerException) : base (message, innerException)
		{

		}
	}

	public class InvalidSignatureException : AuthenticationFailureException
	{
		public InvalidSignatureException (string message, Exception innerException) : base (message, innerException)
		{

		}
	}
	#endregion
	#region ServiceFailureException
	public abstract class ServiceFailureException : DataProviderException, IShouldIgnoreAndRetry
	{
		public ServiceFailureException (string message, Exception innerException) : base (message, innerException)
		{
			
		}
	}
	// The server encountered an internal error trying to fulfill the request.	The server encountered an error while processing your request.
	public class InternalServerErrorException : ServiceFailureException
	{
		public InternalServerErrorException (string message, Exception innerException) : base (message, innerException)
		{

		}
	}
	// The server encountered an internal error trying to fulfill the request.	The server encountered an error while processing your request.
	public class InternalFailure : ServiceFailureException
	{
		public InternalFailure (string message, Exception innerException) : base (message, innerException)
		{

		}
	}
	// The service is currently unavailable or busy.	There was an unexpected error on the server while processing your request.
	public class ServiceUnavailableException : ServiceFailureException
	{
		public ServiceUnavailableException (string message, Exception innerException) : base (message, innerException)
		{

		}
	}
	#endregion
}

