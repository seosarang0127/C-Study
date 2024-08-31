using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 클래스_상속
{
    /*
     *  용어 정리
     *  
     *  
     *  부모로부터 자식이 상속 받았다.
     *  
     *  상속을 받는 객체       vs      상속을 하는 개체
     *  자식(child)                    부모(parent)
     *  Down                         up
     *  파생된(Derived)               기반(base)
     *                               Super
     * 
     * 
     *  접근 지정자
     *  private, public, protected
     * 
     */

    internal class Suits
    {
        public virtual void Equip()
        {
            Console.WriteLine("슈트를 입었습니다.");
        }
    }


    class MK2IronMan : Suits
    {
        public override void Equip()
        {
            base.Equip();
            Console.WriteLine("레이저 기능이 추가됐습니다.");
        }
    }

    class SpiderMan : Suits
    {
        public override void Equip()
        {
            Console.WriteLine("스파이더맨 슈츠를 입었습니다.");
        }
    }
}
/*
 * 
 * 
 */