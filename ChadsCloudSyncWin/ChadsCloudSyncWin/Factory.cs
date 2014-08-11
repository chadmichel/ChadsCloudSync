using ChadsCloudSyncWin.Accessors;
using ChadsCloudSyncWin.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChadsCloudSyncWin
{
    /// <summary>
    /// Used for super light weight dependency injection
    /// </summary>
    public class Factory 
    {
        public T Create<T>()
            where T : class, new()
        {
            if (typeof(T).Name == typeof(IConfigurationManager).Name)
                return new ConfigurationManager() as T;

            if (typeof(T).Name == typeof(ISyncManager).Name)
                return new SyncManager() as T;

            if (typeof(T).Name == typeof(IFileSystemAccessor).Name)
                return new FileSystemAccessor() as T;

            if (typeof(T).Name == typeof(IConfigurationAccessor).Name)
                return new ConfigurationAccessor() as T;

            if (typeof(T).Name == typeof(IAzureBlobAccessor).Name)
                return new AzureBlobAccessor() as T;

            throw new InvalidOperationException("Unable to create type for " + typeof(T).Name);
        }
    }
}
