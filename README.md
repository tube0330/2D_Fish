# 241114
1. 레벨 디자인

# 241115
1. 물고기 크기별로 List 만들고, ObjectPooling
2. Player 움직임 구현
3. 물고기 sprite를 Resources에 미리 불러옴
4. Editor를 사용해 실행중이 아닐때에도 Player의 스프라이트를 레벨에 따라 자동으로 업데이트

# 241117
1. Enemy 물고기 움직임 구현
2. Player 충돌시 물고기 UI 업데이트




/*
* 0: 0.7 no line purple fish
* 1: no line purple fish.       <- player start point
* 2: purple fish
* 3: orange fish
* 4: blue fish
* 5: green fish
* 6: red fish
* 7: blow fish
* 8: small eel
* 9: eel
*/
1. 1단계: 보라색 물고기
퀘스트 목표: 작은 먹이 10개 먹기
설명: 보라색 물고기로 시작하며, 작은 먹이를 잡아 성장하는 첫 번째 단계.
진행: 먹이를 먹으면서 크기가 점차 커지며, 새로운 목표가 열림.
2. 2단계: 보라색 물고기 (scale UP)
퀘스트 목표: 작은 물고기 5마리 잡기
설명: 보라색 물고기가 성장하면서 좀 더 강한 먹이를 사냥할 수 있는 능력을 갖추게 됨.
진행: 작은 물고기를 잡아 퀘스트를 클리어하고, 성장한 보라색 물고기로 다시 도전.
3. 3단계: 주황색 물고기
퀘스트 목표: 작은 물고기 10마리 잡기
설명: 주황색 물고기로 진화하여, 더 큰 먹이를 사냥할 수 있게 되며 새로운 목표가 주어진다.
진행: 작은 물고기를 잡아 경험치를 얻고, 점차 다른 색의 물고기로 성장할 수 있다.
4. 4단계: 파란색 물고기
퀘스트 목표: 중간 크기 물고기 5마리 잡기
설명: 파란색 물고기로 성장하며, 이제 중간 크기 물고기와 싸울 수 있는 능력이 생긴다.
진행: 중간 크기 물고기를 잡아 퀘스트를 클리어하고 다음 단계로 넘어간다.
5. 5단계: 초록색 물고기
퀘스트 목표: 중간 크기 물고기 10마리 잡기
설명: 초록색 물고기로 진화하고, 더 강한 물고기를 사냥하는 능력을 갖추게 된다.
진행: 퀘스트를 클리어하며 점점 성장하고, 마지막 목표를 향해 준비한다.
6. 6단계: 빨간색 물고기
퀘스트 목표: 큰 물고기 5마리 잡기
설명: 빨간색 물고기로 진화하여 이제 대형 물고기를 사냥할 수 있는 강력한 물고기가 된다.
진행: 대형 물고기와 싸우면서 경험치를 쌓고, 최종 보스를 향한 준비가 시작된다.
7. 7단계: 복어와의 대결 (보스전)
퀘스트 목표: 복어 처치하기
설명: 복어는 방어적인 특성과 독 공격을 갖추고 있는 강력한 보스. 복어의 공격 패턴을 잘 파악하고, 약점을 노려 공격해야 한다.
진행: 복어를 처치하고 장어와의 전투로 넘어간다.
8. 8단계: 장어와의 대결 (보스전)
퀘스트 목표: 미니 장어 처치하기
설명: 장어는 빠르고 민첩한 보스로, 전기 공격과 회전 공격을 사용한다. 장어의 공격을 피하면서, 적절한 타이밍에 공격을 해야 한다.
진행: 장어를 처치하면 게임의 최종 엔딩으로 이어진다.
9. 9단계: 장어 처치
어쩌고저쩌고
10. 10단계: 최종 보상과 엔딩
퀘스트 목표: 복어와 장어 모두 처치하기
설명: 두 보스를 처치한 후, **"마스터 물고기"**로 진화하며 특별 능력을 얻고, 최종 보상을 받는다.
게임 마무리: **"물고기 왕"**이 되어 게임을 마친다. 추가적으로 자유 성장 모드나 새로운 도전을 위한 선택지를 제공할 수 있다.

퀘스트 흐름 요약:
1단계~7단계: 각 단계마다 물고기가 성장하고, 퀘스트 목표를 달성하며 다음 단계로 나아간다.
8단계~9단계: 복어와 장어라는 보스 물고기와의 전투가 시작된다.
10단계: 최종 보스를 처치하고, 보상으로 새로운 능력을 얻으며 게임을 마친다.