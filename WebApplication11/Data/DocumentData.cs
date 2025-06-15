using WebApplication11.Models;

namespace WebApplication11.Data
{
    public class DocumentData
    {
        public List<Document> Documents {

            get
            {
                return new List<Document>
                {
                    new Document { Document_Number = 1, Title = "공지사항입니다.", Writer = "홍길동" },
                    new Document { Document_Number = 2, Title = "회의 일정 공지", Writer = "김영희" },
                    new Document { Document_Number = 3, Title = "업무 분장표입니다.", Writer = "박철수" },
                    new Document { Document_Number = 4, Title = "추석 휴무 안내", Writer = "이민정" },
                    new Document { Document_Number = 5, Title = "보안 교육 자료", Writer = "최정훈" }
                 };
            }

        }
    }
}
