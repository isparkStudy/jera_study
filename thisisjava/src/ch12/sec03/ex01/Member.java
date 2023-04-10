package ch12.sec03.ex01;

public class Member {
	public String id;
	
	public Member(String id) {
		this.id = id;
	}
	
// 동등 비교 기능이 필요하다면 equals 를 재정의해서 써야한다.
	@Override
	public boolean equals(Object obj) {
		if(obj instanceof Member target) {
			if(id.equals(target.id)) {
				return true;
			}
		}
		return false;
		
	}
	 
}
