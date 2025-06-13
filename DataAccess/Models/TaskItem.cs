namespace NTierTodoApp.Models
{
    /// <summary>
    /// يمثل نموذج المهمة.
    /// </summary>
    public class TaskItem
    {
        public int Id { get; set; }             // رقم المعرف الفريد للمهمة
        public string Title { get; set; }       // عنوان أو وصف المهمة
        public bool IsComplete { get; set; }    // هل اكتملت المهمة؟
    }
}
