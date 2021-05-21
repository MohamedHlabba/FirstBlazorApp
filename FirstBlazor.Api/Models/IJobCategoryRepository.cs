using FirstBlazorWebAssebly.Shared;
using System.Collections.Generic;

namespace FirstBlazor.Api.Models
{
    public interface IJobCategoryRepository
    {
        IEnumerable<JobCategory> GetAllJobCategories();
        JobCategory GetJobCategoryById(int jobCategoryId);
    }
}
