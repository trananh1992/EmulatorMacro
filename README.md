﻿
연결 프로세스의 화면을 분석해서 키보드나 마우스 이벤트 반복

<img src="https://github.com/EomTaeWook/EmulatorMacro/blob/master/Release/Resource/capture.png" width="100%"></img>

개발환경

    WPF, C#, .net 4.6.1
    
OS 버전

    Window 8.0 이상 Window 7 에서는 작동 안하는 기능이 있음.

사용 방법
    
    1.트리거 저장

        1.1 화면 캡쳐 버튼를 통하여 찾고 싶은 이미지 캡쳐
    
        1.2 이미지, 마우스, 키보드 이벤트 선택
    
            - 이미지 : 찾은 이미지를 클릭합니다.

            - 마우스 이벤트 : 좌표 지정(클릭) 해주시면 됩니다.
        
            - 키보드 이벤트 : Ctrl + c + v 이런식으로 조합키를 넣어주면 됩니다.
        
        1.3 실행시 이미지를 캡쳐할 실행 프로세스를 선택하시면 됩니다.

        1.4 후 작업 딜레이

            - 현재 작업이 완료 이후 어느 정도 대기를 한 후 다음 작업을 하고 싶은 경우에 사용하시면 됩니다.(아이디어 Ko9ma7 제공)

            - ex> 버튼 클릭 => 팝업 뜨기까지 대기 => 확인 버튼 클릭 (연계하는 경우)

        1.5 저장

    2.드래그 앤 드랍으로 트리 노드 순서도 변경

    3.여러 게임의 세이브 파일을 저장하고 싶은 경우 setting에서 세이브 경로를 다르게 하여 저장하세요.

    4.연결 프로세스 리스트 
        
        - 프로세스가 목록에 없는 경우 또는 종료되거나 새로운 프로세스를 실행 시켰을시엔 새로고침 버튼을 눌러주세요.

    5.이미지 조합을 통한 이벤트 발생 방법

    <img src="https://github.com/EomTaeWook/EmulatorMacro/blob/master/Release/Resource/ImageCombination.png" width="100%"></img>

설정(Config.json 혹은 프로그램 내 Setting)

    1.Language 언어 : [Eng],[Kor]
    
    2.SavePath : 설정 리스트 save 경로
    
    3.Period : 전체 작업 완료 이후 딜레이

    4.ItemDelay : 트리거 아이템 작업 완료 다음 작업까지 딜레이(공통)
    
    5.Similarity : 이미지 프로세싱 유사도

    6.VersionCheck : [true],[false] : 프로그램 실행시 버전 체크 확인

작업 목록

    8 에뮬레이터 사이즈 변경시 크기 비율에 따른 캡쳐 이미지 사이즈 변경

    11.OpenCV ROI 기능 적용

    2019-01-16 Feedback

    14.마우스 이벤트 드래그 앤 드랍 기능 추가(작업 중)

릴리즈

2.0.0

    1.기존의 Save 파일은 지원 안됩니다.

    2.이벤트 목록 트리 형식으로 변경

    - 자식 노드가 있는 경우 이미지를 검색만 합니다.

    - 자식 노드가 없는 경우 이벤트가 발생됩니다.

    - 사용 방법

        드래그 앤 드랍으로 노드 레벨을 변경합니다.

        클릭하고 버튼으로 위치 이동

    ex) item 이미지 검색

        ㄴ item 이미지 검색

            ㄴ item 트리거 발생

    3.버그 수정

1.4.4

    리스트 드래그 앤 드랍 방식 변경

    이벤트 타입 키보드인 경우 저장 안되는 현상 수정

    성능 개선

    이벤트 타입 추가

    설정 최소 값 100ms 통일

1.4.3

    DPI 버그 수정, SavePath 팝업으로 저장시 불러오기 제대로 안되는 부분 수정, 최소 설정 값 수정, 라벨 변경

1.4.2

    단일 작업별 후 딜레이 적용 안되는 버그 수정

1.4.1

    리스트 아이템 드래그 앤 드랍시 순서도 정확하게 변경 안되는 버그 수정

1.4.0

    2019-01-15 Feedback

    단일 작업별 후 딜레이 설정(후 딜레이 => 아이템 개별 설정)

    버전 체크 옵션화

    저장 방식 변경 =>

    트리거 아이템 변경시 원본을 남겨두고 마지막에 추가 방식 => 트리거 아이템 원본 수정

1.3.1

    모니터별 해상도 별 이미지 프로세싱 작업 완료, 마우스 이벤트 좌표계 버그 수정

1.3.0

    리스트 Drag And Drop으로 순서 변경 기능 추가

1.2.2

    버전 체크 및 Install 파일 변경

1.2.1

    Mouse Event 방식 변경

    물리적인 마우스 이벤트 -> 논리적 마우스 이벤트 방식의 변경

    프로그래스바 버그 수정

1.2.0 

    setting view 추가

    2019-01-09 Feedback

    작업간의 중간 딜레이 설정 기능 추가, 딜레이를 통한 CPU 사용률 저하 확인

1.1.1

    UI 비동기 처리가 안 되어서 프로그램이 응답없음 뜨는 오류 수정.

1.1.0

    세이브 파일 확장성 고려 및 에뮬레이터 사이즈 변경없이 이동시키는 경우 마우스 보정 작업

1.0.0 

    기본 기능 완료

버그 레포팅

    enter0917@naver.com
