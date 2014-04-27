











/*******************************************************************************
 *  Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *
 */
using System;
using Amazon.Runtime;


using Amazon.DynamoDBv2;

using Amazon.IdentityManagement;

using Amazon.S3;

using Amazon.SecurityToken;


namespace Amazon
{
    /// <summary>
    /// The Amazon Web Services SDK provides devlopers with a coherent and unified interface to the
    /// suite of Amazon Web Services. The intent is to facilitate the rapid building of
    /// applications that leverage multiple Amazon Web Services.
    /// <para>
    /// To get started, request an instance of the AWSClientFactory via this class's static Instance
    /// member. Use the factory instance to create clients for all the Web Services needed by
    /// the application.</para>
    /// </summary>

    public static class AWSClientFactory
    {

        #region Amazon DynamoDB

        /// <summary>
        /// Create a client for the Amazon DynamoDB Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <returns>An Amazon DynamoDB client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonDynamoDB CreateAmazonDynamoDBClient()
        {
            return new AmazonDynamoDBClient();
        }

        /// <summary>
        /// Create a client for the Amazon DynamoDB Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon DynamoDB client</returns>
        public static IAmazonDynamoDB CreateAmazonDynamoDBClient(AmazonDynamoDBConfig config)
        {
            return new AmazonDynamoDBClient(config);
        }

        /// <summary>
        /// Create a client for the Amazon DynamoDB Service with the default configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <returns>An Amazon DynamoDB client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonDynamoDB CreateAmazonDynamoDBClient(
            string awsAccessKey,
            string awsSecretAccessKey
            )
        {
            return new AmazonDynamoDBClient(awsAccessKey, awsSecretAccessKey);
        }

        /// <summary>
        /// Create a client for the Amazon DynamoDB Service with the specified configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc
        /// </param>
        /// <returns>An Amazon DynamoDB client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonDynamoDB CreateAmazonDynamoDBClient(
            string awsAccessKey,
            string awsSecretAccessKey, AmazonDynamoDBConfig config
            )
        {
            return new AmazonDynamoDBClient(awsAccessKey, awsSecretAccessKey, config);
        }

        /// <summary>
        /// Create a client for the Amazon DynamoDB Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon DynamoDB client</returns>
        public static IAmazonDynamoDB CreateAmazonDynamoDBClient(RegionEndpoint region)
        {
            return new AmazonDynamoDBClient(region);
        }

        /// <summary>
        /// Create a client for the Amazon DynamoDB Service with the specified region
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon DynamoDB client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonDynamoDB CreateAmazonDynamoDBClient(
            string awsAccessKey,
            string awsSecretAccessKey, RegionEndpoint region
            )
        {
            return new AmazonDynamoDBClient(awsAccessKey, awsSecretAccessKey, region);
        }

        /// <summary>
        /// Create a client for the Amazon DynamoDB Service with AWSCredentials.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <returns>An Amazon DynamoDB client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonDynamoDB CreateAmazonDynamoDBClient(AWSCredentials credentials)
        {
            return new AmazonDynamoDBClient(credentials);
        }

        /// <summary>
        /// Create a client for the Amazon DynamoDB Service with AWSCredentials and region.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon DynamoDB client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonDynamoDB CreateAmazonDynamoDBClient(AWSCredentials credentials, RegionEndpoint region)
        {
            return new AmazonDynamoDBClient(credentials, region);
        }

        /// <summary>
        /// Create a client for the Amazon DynamoDB Service with AWSCredentials and an AmazonDynamoDB Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon DynamoDB client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonDynamoDB CreateAmazonDynamoDBClient(AWSCredentials credentials, AmazonDynamoDBConfig config)
        {
            return new AmazonDynamoDBClient(credentials, config);
        }
        #endregion


        #region Amazon IdentityManagementService

        /// <summary>
        /// Create a client for the Amazon IdentityManagementService Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <returns>An Amazon IdentityManagementService client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonIdentityManagementService CreateAmazonIdentityManagementServiceClient()
        {
            return new AmazonIdentityManagementServiceClient();
        }

        /// <summary>
        /// Create a client for the Amazon IdentityManagementService Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon IdentityManagementService client</returns>
        public static IAmazonIdentityManagementService CreateAmazonIdentityManagementServiceClient(AmazonIdentityManagementServiceConfig config)
        {
            return new AmazonIdentityManagementServiceClient(config);
        }

        /// <summary>
        /// Create a client for the Amazon IdentityManagementService Service with the default configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <returns>An Amazon IdentityManagementService client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonIdentityManagementService CreateAmazonIdentityManagementServiceClient(
            string awsAccessKey,
            string awsSecretAccessKey
            )
        {
            return new AmazonIdentityManagementServiceClient(awsAccessKey, awsSecretAccessKey);
        }

        /// <summary>
        /// Create a client for the Amazon IdentityManagementService Service with the specified configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc
        /// </param>
        /// <returns>An Amazon IdentityManagementService client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonIdentityManagementService CreateAmazonIdentityManagementServiceClient(
            string awsAccessKey,
            string awsSecretAccessKey, AmazonIdentityManagementServiceConfig config
            )
        {
            return new AmazonIdentityManagementServiceClient(awsAccessKey, awsSecretAccessKey, config);
        }

        /// <summary>
        /// Create a client for the Amazon IdentityManagementService Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon IdentityManagementService client</returns>
        public static IAmazonIdentityManagementService CreateAmazonIdentityManagementServiceClient(RegionEndpoint region)
        {
            return new AmazonIdentityManagementServiceClient(region);
        }

        /// <summary>
        /// Create a client for the Amazon IdentityManagementService Service with the specified region
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon IdentityManagementService client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonIdentityManagementService CreateAmazonIdentityManagementServiceClient(
            string awsAccessKey,
            string awsSecretAccessKey, RegionEndpoint region
            )
        {
            return new AmazonIdentityManagementServiceClient(awsAccessKey, awsSecretAccessKey, region);
        }

        /// <summary>
        /// Create a client for the Amazon IdentityManagementService Service with AWSCredentials.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <returns>An Amazon IdentityManagementService client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonIdentityManagementService CreateAmazonIdentityManagementServiceClient(AWSCredentials credentials)
        {
            return new AmazonIdentityManagementServiceClient(credentials);
        }

        /// <summary>
        /// Create a client for the Amazon IdentityManagementService Service with AWSCredentials and region.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon IdentityManagementService client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonIdentityManagementService CreateAmazonIdentityManagementServiceClient(AWSCredentials credentials, RegionEndpoint region)
        {
            return new AmazonIdentityManagementServiceClient(credentials, region);
        }

        /// <summary>
        /// Create a client for the Amazon IdentityManagementService Service with AWSCredentials and an AmazonIdentityManagementService Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon IdentityManagementService client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonIdentityManagementService CreateAmazonIdentityManagementServiceClient(AWSCredentials credentials, AmazonIdentityManagementServiceConfig config)
        {
            return new AmazonIdentityManagementServiceClient(credentials, config);
        }
        #endregion


        #region Amazon S3

        /// <summary>
        /// Create a client for the Amazon S3 Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <returns>An Amazon S3 client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonS3 CreateAmazonS3Client()
        {
            return new AmazonS3Client();
        }

        /// <summary>
        /// Create a client for the Amazon S3 Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon S3 client</returns>
        public static IAmazonS3 CreateAmazonS3Client(AmazonS3Config config)
        {
            return new AmazonS3Client(config);
        }

        /// <summary>
        /// Create a client for the Amazon S3 Service with the default configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <returns>An Amazon S3 client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonS3 CreateAmazonS3Client(
            string awsAccessKey,
            string awsSecretAccessKey
            )
        {
            return new AmazonS3Client(awsAccessKey, awsSecretAccessKey);
        }

        /// <summary>
        /// Create a client for the Amazon S3 Service with the specified configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc
        /// </param>
        /// <returns>An Amazon S3 client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonS3 CreateAmazonS3Client(
            string awsAccessKey,
            string awsSecretAccessKey, AmazonS3Config config
            )
        {
            return new AmazonS3Client(awsAccessKey, awsSecretAccessKey, config);
        }

        /// <summary>
        /// Create a client for the Amazon S3 Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon S3 client</returns>
        public static IAmazonS3 CreateAmazonS3Client(RegionEndpoint region)
        {
            return new AmazonS3Client(region);
        }

        /// <summary>
        /// Create a client for the Amazon S3 Service with the specified region
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon S3 client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonS3 CreateAmazonS3Client(
            string awsAccessKey,
            string awsSecretAccessKey, RegionEndpoint region
            )
        {
            return new AmazonS3Client(awsAccessKey, awsSecretAccessKey, region);
        }

        /// <summary>
        /// Create a client for the Amazon S3 Service with AWSCredentials.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <returns>An Amazon S3 client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonS3 CreateAmazonS3Client(AWSCredentials credentials)
        {
            return new AmazonS3Client(credentials);
        }

        /// <summary>
        /// Create a client for the Amazon S3 Service with AWSCredentials and region.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon S3 client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonS3 CreateAmazonS3Client(AWSCredentials credentials, RegionEndpoint region)
        {
            return new AmazonS3Client(credentials, region);
        }

        /// <summary>
        /// Create a client for the Amazon S3 Service with AWSCredentials and an AmazonS3 Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon S3 client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonS3 CreateAmazonS3Client(AWSCredentials credentials, AmazonS3Config config)
        {
            return new AmazonS3Client(credentials, config);
        }
        #endregion


        #region Amazon SecurityTokenService

        /// <summary>
        /// Create a client for the Amazon SecurityTokenService Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <returns>An Amazon SecurityTokenService client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonSecurityTokenService CreateAmazonSecurityTokenServiceClient()
        {
            return new AmazonSecurityTokenServiceClient();
        }

        /// <summary>
        /// Create a client for the Amazon SecurityTokenService Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon SecurityTokenService client</returns>
        public static IAmazonSecurityTokenService CreateAmazonSecurityTokenServiceClient(AmazonSecurityTokenServiceConfig config)
        {
            return new AmazonSecurityTokenServiceClient(config);
        }

        /// <summary>
        /// Create a client for the Amazon SecurityTokenService Service with the default configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <returns>An Amazon SecurityTokenService client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonSecurityTokenService CreateAmazonSecurityTokenServiceClient(
            string awsAccessKey,
            string awsSecretAccessKey
            )
        {
            return new AmazonSecurityTokenServiceClient(awsAccessKey, awsSecretAccessKey);
        }

        /// <summary>
        /// Create a client for the Amazon SecurityTokenService Service with the specified configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc
        /// </param>
        /// <returns>An Amazon SecurityTokenService client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonSecurityTokenService CreateAmazonSecurityTokenServiceClient(
            string awsAccessKey,
            string awsSecretAccessKey, AmazonSecurityTokenServiceConfig config
            )
        {
            return new AmazonSecurityTokenServiceClient(awsAccessKey, awsSecretAccessKey, config);
        }

        /// <summary>
        /// Create a client for the Amazon SecurityTokenService Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon SecurityTokenService client</returns>
        public static IAmazonSecurityTokenService CreateAmazonSecurityTokenServiceClient(RegionEndpoint region)
        {
            return new AmazonSecurityTokenServiceClient(region);
        }

        /// <summary>
        /// Create a client for the Amazon SecurityTokenService Service with the specified region
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon SecurityTokenService client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonSecurityTokenService CreateAmazonSecurityTokenServiceClient(
            string awsAccessKey,
            string awsSecretAccessKey, RegionEndpoint region
            )
        {
            return new AmazonSecurityTokenServiceClient(awsAccessKey, awsSecretAccessKey, region);
        }

        /// <summary>
        /// Create a client for the Amazon SecurityTokenService Service with AWSCredentials.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <returns>An Amazon SecurityTokenService client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonSecurityTokenService CreateAmazonSecurityTokenServiceClient(AWSCredentials credentials)
        {
            return new AmazonSecurityTokenServiceClient(credentials);
        }

        /// <summary>
        /// Create a client for the Amazon SecurityTokenService Service with AWSCredentials and region.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon SecurityTokenService client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonSecurityTokenService CreateAmazonSecurityTokenServiceClient(AWSCredentials credentials, RegionEndpoint region)
        {
            return new AmazonSecurityTokenServiceClient(credentials, region);
        }

        /// <summary>
        /// Create a client for the Amazon SecurityTokenService Service with AWSCredentials and an AmazonSecurityTokenService Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon SecurityTokenService client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonSecurityTokenService CreateAmazonSecurityTokenServiceClient(AWSCredentials credentials, AmazonSecurityTokenServiceConfig config)
        {
            return new AmazonSecurityTokenServiceClient(credentials, config);
        }
        #endregion



    }
}