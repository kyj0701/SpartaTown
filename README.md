# SpartaTown
내일배움캠프 Unity A08 팔이바게트 김예준

SpartaTown like gather (made by Unity)

![image](https://github.com/kyj0701/SpartaTown/assets/31722243/06811c23-c51c-4062-9762-cc24c9213156)


# 필수요구사항

## 1. 캐릭터 만들기

* 외부 그림파일을 추가하여 2D 캐릭터를 추가합니다.
* [Nine Pines Animation]([https://github.com/kyj0701/SpartaTown/blob/main/Assets/Externals/Nine%20Pines%20Animation/2D%20Character%20Sprite%20Animation%20-%20Penguin/sprites/penguin_idle_01.png](https://assetstore.unity.com/packages/2d/characters/2d-character-sprite-animation-penguin-236747))

## 2. 캐릭터 이동

* 키보드 A/W/S/D 를 이용하여 캐릭터가 움직입니다.
* 캐릭터는 마우스 방향을 바라봅니다. (좌/우)
* InputSystem 활용
* [TopDownCharacterController.cs](https://github.com/kyj0701/SpartaTown/blob/main/Assets/Scripts/Controller/TopDownCharacterController.cs)
* [PlayerInputController.cs](https://github.com/kyj0701/SpartaTown/blob/main/Assets/Scripts/Controller/PlayerInputController.cs)
* [TopDownMovement.cs](https://github.com/kyj0701/SpartaTown/blob/main/Assets/Scripts/Entities/TopDownMovement.cs)

## 3. 방 만들기

* 타일맵을 이용하여 맵을 만듭니다.
* 콜라이더를 이용해 벽을 넘어가지 못합니다.
* [Rogue Fantansy Castle](https://assetstore.unity.com/packages/2d/environments/rogue-fantasy-castle-164725)

## 4. 카메라 따라가기

* 카메라는 움직임에 따라 캐릭터를 따라갑니다.
* [CameraMove.cs](https://github.com/kyj0701/SpartaTown/blob/main/Assets/Scripts/CameraMove.cs)



# 선택요구사항

## 1. 캐릭터 애니메이션 추가

* 캐릭터가 가만히 있을 때의 애니메이션 (Player Idle)
* 캐릭터가 움직일 때의 애니메이션 추가 (Player Walk)

## 2. 이름 입력 시스템

* 스파르타 타운 입장 전 플레이어의 이름을 입력할 수 있습니다.
  * 2~10 글자 사이
* 캐릭터 위에 이름이 표시됩니다.

## 3. 캐릭터 선택 시스템

* 스파르타 타운 입장 전 캐릭터가 표시됩니다.
* 캐릭터를 클릭하면 캐릭터를 선택하는 팝업이 나타납니다.
* 캐릭터를 선택하면 캐릭터가 변경이 되고 팝업이 닫힙니다.
* 스파르타 타운에 입장하면 선택했던 캐릭터가 표시됩니다.

## 4. 참석 인원 UI
* UI는 캐릭터가 움직여도 화면에 고정됩니다.
* 화면 오른쪽에 현재 스파르타 타운에 접속한 사람의 목록을 보여줍니다.
  * X 버튼을 누르면 UI가 꺼집니다.
