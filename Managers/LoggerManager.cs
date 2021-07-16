using Contracts;
using Entities;
using System;

namespace LoggerService
{
    public class LoggerManager : ILoggerManager
    {
        private RepositoryContext _repositoryContext;
        public LoggerManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }
        public void LogError(object entity)
        {
            this._repositoryContext.Set<object>().Add(entity);
        }
        public void LogInfo(object entity)
        {
            this._repositoryContext.Set<object>().Add(entity);
        }
    }
}
