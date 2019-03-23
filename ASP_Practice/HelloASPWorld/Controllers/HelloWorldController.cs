using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


//MVC는 들어오는 URL에 따라 컨트롤러 클래스(및 그 안에있는 동작 메서드)를 호출합니다.MVC에서 사용하는 기본 URL 라우팅 논리 는 다음과 같은 형식을 사용하여 호출 할 코드를 결정합니다.

///[Controller]/[ActionName]/[Parameters]
namespace HelloASPWorld.Controllers
{
    public class HelloWorldController : Controller
    {
        //GET : /HelloWorld ??? 베이직 함수?
        public string Index()
        {
            return "This is my default action...";
        }

        //GET : /HelloWorld/Welcome/
        public string Welcome()
        {
            return "This is the Welcome action method...";
        }

        //URL에서 컨트롤러로 일부 매개 변수 정보를 전달하도록 코드를 수정하십시오.예를 들어, /HelloWorld/Welcome? name = Rick & numtimes = 4.Welcome다음 코드와 같이 두 개의 매개 변수를 포함 하도록 메서드를 변경합니다.
        //GET : /HelloWorld/VarTest/
        public string VarTest(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }

        public string VarTest2(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID : {ID}");
        }

        //HtmlEncoder.Default.Encode악의적 인 입력 (자바 스크립트)으로부터 앱을 보호하기 위해 사용 합니다.
        //위 이미지에서 URL 세그먼트 ( Parameters)는 사용되지 않고 name및 numTimes매개 변수는 쿼리 문자열 로 전달됩니다 . ?위 URL 의 (물음표)는 구분 기호이며 쿼리 문자열이옵니다. &문자 쿼리 문자열을 분리한다.
    }
}