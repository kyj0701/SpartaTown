# SpartaTown
SpartaTown like gather (made by Unity)



# 필수요구사항

## 1. 캐릭터 만들기

* 외부 그림파일을 추가하여 2D 캐릭터를 추가합니다.
* [Nine Pines Animation]([https://github.com/kyj0701/SpartaTown/blob/main/Assets/Externals/Nine%20Pines%20Animation/2D%20Character%20Sprite%20Animation%20-%20Penguin/sprites/penguin_idle_01.png](https://assetstore.unity.com/packages/2d/characters/2d-character-sprite-animation-penguin-236747))

## 2. 캐릭터 이동

* 키보드 A/W/S/D 를 이용하여 캐릭터가 움직입니다.
* 캐릭터는 마우스 방향을 바라봅니다. (좌/우)
* InputSystem 활용
* [TopDownCharacterController.cs](https://github.com/kyj0701/SpartaTown/blob/main/Assets/Scripts/Controller/TopDownCharacterController.cs), [PlayerInputController.cs](https://github.com/kyj0701/SpartaTown/blob/main/Assets/Scripts/Controller/PlayerInputController.cs), [TopDownMovement.cs](https://github.com/kyj0701/SpartaTown/blob/main/Assets/Scripts/Entities/TopDownMovement.cs)

## 3. 방 만들기

* 타일맵을 이용하여 맵을 만듭니다.
* 콜라이더를 이용해 벽을 넘어가지 못합니다.
* [Rogue Fantansy Castle](https://assetstore.unity.com/packages/2d/environments/rogue-fantasy-castle-164725)

## 4. 카메라 따라가기

* 카메라는 움직임에 따라 캐릭터를 따라갑니다.
* [CameraMove.cs](https://github.com/kyj0701/SpartaTown/blob/main/Assets/Scripts/CameraMove.cs)



# 선택요구사항

