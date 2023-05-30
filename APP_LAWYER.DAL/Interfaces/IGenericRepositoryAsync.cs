namespace APP_LAWYER.DAL.Interfaces;

public interface IGenericRepositoryAsync<T> where T : class
{
    Task<IReadOnlyList<T>> ListAllAsync();
    Task<T> GetByIDAsync(int id);
    Task<T> GetBySlugAsync(string slug);
    Task<T> InsertAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
    Task<IReadOnlyList<T>> GetPagedAsync(int page, int size);
}