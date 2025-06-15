using WebApplication11.Data;

namespace WebApplication11.Models
{
    public class MemberActs
    {
        public Member GetMember(int paramMemberNumber)
        {

            MemberData memberData = new MemberData();
            //LINQ
            // 멤버정보에서 검색을 한다음에 하나의 값만 리턴 
           return memberData.Members.Where(x => x.Member_Number == paramMemberNumber)
                .SingleOrDefault();

        }

    }
}
