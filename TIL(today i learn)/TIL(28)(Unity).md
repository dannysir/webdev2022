# 2022-10-25 TIL

# Unity

### 유니티의 대표적인 조명

---

- 점 광원 ( Point Light )
    - 정해진 위치에서 사방으로 퍼져나가는 빛
    - 물체까지의 거리에 따라 빛의 세기가 감소함

- 방향성 광원 ( Directional Light )
    - 태양광선과 같이 무한히 먼 곳에서 오는 빛
        - 바향만 존재, 어디서든 빛의 세기가 일정

- 스포트라이트 ( Spotlight )
    - 정해진 위치에서 일정 방향으로 퍼져나가는 빛
        - 빛이 방사되는 한계 각도( spot angle ) 존재

### 스크립트

---

- 물체가 움직이는 시나리오
- ‘Assets’ → ‘Create’ → ‘C# Script’
    - 처음 생성 시 이름을 확정
        - 이 때 확정된 이름이 클래스명이 됨
        - 파일이름과 클래스명이 같아야 유니티가 찾을 수 있음

스크립트 연결 

- 스크립트 파일을 드래그해서 Sphere 에 연결, 또는
- Sphere 선택 후 [Add Component] → ‘Scripts’

스크립트 변수 선언 

- 스크립트의 루트에서 선언한 public 변수
    - Inspector 에 나타남
        - 지정된 변수 값을 Inspector 상에서 수정하여 테스트 가능
- 함수 내에서 선언한 변수
    - 지역 변수 : 인스펙터에 나타나지 않음
- 유니티의 이름 선언 규칙
    - 변수 : 소문자로 시작
    - 한수 및 클래스 : 대문자로 시작

### 콘솔

---

- 프로그램 실행 시 디버그 및 다양한 메시지가 출력
- 옵션
    - Clear on Play : 실행 시 콘솔창을 지우고 다시 기록
    - Error Pause : 에러가 나면 멈춤
    - Collapse : 같은 종류의 에러를 하나로 표시

- 디버그

```csharp
Debug.Log("hello");
```

위 코드를 입력하면 콘솔 화면에 메시지가 뜬다 

### 유니티의 입력시스템

---

- [Edit] → [Project Setting] → [Input]
- 마우스 버튼
    - mouse 0 : 왼쪽 버튼
    - mouse 1 : 오른쪽 버튼
    - mouse 2 : 가운데 버튼
- 매 프레임마다 호출되는 Update()에서 처리
    - 키를 언제 누르더라도 대응 가능하도록
- Input 클래스
    - 사용자의 키 입력을 판정하는 클래스
        - Input.GetAxis(”Horizontal”) : 좌우 이동키의 이동 방향
        - Input.GetAxis(”Vertical”) : 앞뒤 이동키의 이동 방향
        - Input.GetKeyDown() : 특정 키를 눌렀는지 여부
        - Input.GetButtonDown() : 특정한 키나 버튼을 눌렀는 지 여부
        - Input.GetMouseButtonDown() : 마우스버튼을 눌렀는 지 여부
        - Input.GetTouch() : 터치스크린 화면을 눌렀는지 여부