namespace Core.Entities.Concrete
{
    public class UserOperationClaim
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int OperationClaimId { get; set; }
        public OperationClaim OperationClaim { get; set; }
        public User User { get; set; }
    }
}

//many useroperationclaim 1 operationclaim
//many useroperationclaim 1 user