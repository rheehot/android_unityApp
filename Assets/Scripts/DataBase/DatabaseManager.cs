﻿/**
 * @brief 데이터베이스모음/관리
 * @date 2020/03/05 마지막수정
 * @file DatabaseManager.cs
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatabaseManager : MonoBehaviour
{

    public static List<News> newsDataList; /* 뉴스 거리 데이터베이스*/
    public static List<SimpleNote> buildingConditionNoteList; /* 건물이 더러워졌을 때 주민들이 보내는 쪽지 데이터베이스 */

    //사다리
    public static string sadariGameItem;

    //사다리게임 결과 받아서 데이타베이스에 저장
    public void GetItemResult(string item)
    {
        sadariGameItem = item;
    }

    // Start is called before the first frame update
    void Start()
    {
        newsDataList = new List<News>();
        InitNewsData();
        if (newsDataList.Count == 0)
            InitNewsData();
        buildingConditionNoteList = new List<SimpleNote>();
        InitBuildingConditionNoteData();
    }

    /* 건물이 더러워졌을 때 주민들이 보내는 쪽지 */
    private void InitBuildingConditionNoteData()
    {
        buildingConditionNoteList.Add(new SimpleNote("아니 건물이 왜이렇게 드러워요? 관리를 하는 거야 안하는거야 나 나갈 테니까 그런줄 아쇼!"));
        buildingConditionNoteList.Add(new SimpleNote("우웩, 건물 화장실에 거미가 있어요. 관리비를 내는 이유를 모르겠는데, 나 이번 달 안낼래!"));
        buildingConditionNoteList.Add(new SimpleNote("엘레베이터에서 냄새가 나서 못살겠어요. 나 나갈래."));
        buildingConditionNoteList.Add(new SimpleNote("건물이 너무 낡아서 쓰러질거 같아요. 어떻게 그러면서 월세를 이만큼을 받아? 양심이 있는 거야 없는거야."));
        buildingConditionNoteList.Add(new SimpleNote("건물 페인트 칠 좀 다시 해주시면 안되요?? 어우 짜증나."));
        buildingConditionNoteList.Add(new SimpleNote("건물 쓰레기통좀 비워주세요. 쓰레기 냄새가 너무 나서..."));
        buildingConditionNoteList.Add(new SimpleNote("건물이 너무 낡았어요. 수준 떨어져서 못 살겠네 정말"));
        buildingConditionNoteList.Add(new SimpleNote("관리자 맞으시죠? 건물 보수 좀 부탁드려요. 안 그러면 저 다음 달에 나갈 거에요!"));
        buildingConditionNoteList.Add(new SimpleNote("건물 한번만 싹 청소 좀 해주세요. 안 그러면 저 다음 달에 나갈 거에요!"));
        buildingConditionNoteList.Add(new SimpleNote("으악 ! 이 빌딩에 더 이상 못살겠어요. 리모델링 좀 해주세요. 안 그러면 저 다음 달에 나갈 거에요!"));
        buildingConditionNoteList.Add(new SimpleNote("미안하다, 이건물 보여줄려고 어그로끌었다. 사람사는 건물 수준 실화냐?"));
        buildingConditionNoteList.Add(new SimpleNote("이 집의 장점은 환풍이에요^^ 문을 다닫아도 바람이 다들어와~"));
        buildingConditionNoteList.Add(new SimpleNote("이 동네는 주민들끼리 소통이 참 잘되더라구요! 밑집에서 하는 얘기가 다들려! 방음따윈 개나줘버린거야~!"));
        buildingConditionNoteList.Add(new SimpleNote("우리 곤충원가요 엄마!! 아... 아니다 여기가 곤충원이구나^^"));
    }

    private void InitNewsData()
    {
        newsDataList.Add(new News(100, "신문", "삼숭의 아이폰이 최근 양산에 돌입해 이르면 몇 주 내 출시될 것이라고 IT매체 Z가 22일(현지시간) A기업 내부 소식통을 인용해 보도했다", 0, 0.3f, 20));
        newsDataList.Add(new News(100, "신문", "내이벌이 11일(현지시간) 미국 샌프란시스코에서 열린 ‘IT 2020’에서 명품 패션 브랜드 C와 협업한 프리미엄 패키지 ‘에이폰 C 에디션’을 공개했다. ", 1, 0.2f, 20));
        newsDataList.Add(new News(100, "신문", "MC소프트의 기대를 모았던 화제작 접히는 휴대폰을 공개하였습니다.많은 언플루언서들의 찬사가 빗발치고 1차 물량은 모두 매진되었습니다", 2, 0.2f, 20));
        newsDataList.Add(new News(100, "신문", "삼숭의 보급형 제품의 출시에 많은 소비자들이 탁월한 제품 출시라며 환호하였고 예약 판매사이트 초도 물량은 모두 동이 났다고 전해졌습니다.", 0, 0.2f, 20));
        newsDataList.Add(new News(100, "신문", "삼숭은 다음달 초에 누구도 경험해보지 못한 혁신적인 울트라 뉴 플래그쉽 제품이 출시 될거라고 발표했습니다.", 0, 0.2f, 20));
        newsDataList.Add(new News(100, "신문", "내이벌 서비스 에이그램에서 4일(현지 시간) 인공 지능을 이용한 신기능을 추가했다고 발표했습니다. 이 기능은 출시 전부터 기대를 모은 기능으로 많은 관심사를 끌고 있습니다.", 1, 0.2f, 30));
        newsDataList.Add(new News(100, "신문", "내이벌에서 사진, 동영상 공유 플랫폼 에이그램의 보다 재미있는 콘텐츠 작성을 위한 신기능을 내놨다고 17일 밝혔다.", 1, 0.2f, 20));
        newsDataList.Add(new News(100, "신문", "삼숭이 15일(현지시간) 미국 뉴욕에서 레이더로 얼굴을 인식하고 밤하늘 별까지 촬영이 가능한 울트라 나이트 카메라 기능을 공개했다.", 0, 0.3f, 30));
        newsDataList.Add(new News(100, "신문", "MC소프트가 새로운 소프트웨어 버전을 발표하였습니다.많은 it제품 크리에이터들이 놀라운 기능들이 들어간 혁신적인 업데이트라며 긍정적인 반응을 보였습니다.", 2, 0.2f, 20));
        newsDataList.Add(new News(100, "신문", "MC소프트가 다음달 말에 새로운 버전의 소프트웨어를 공개할 것이라고 발표하였습니다.고위 관계자는 기대해도 좋을것이라는 코멘트를 달았습니다.", 2, 0.2f, 20));
        newsDataList.Add(new News(100, "신문", "삼숭이 지금까지 존재하던 틀을 깨는 새로운 제품을 공개할 것이라 발표하였습니다.내부 관계자의 말에 따르면 콩나물 프로젝트가 완성된거 같다고 전해주었습니다.", 0, 0.2f, 20));
        newsDataList.Add(new News(100, "신문", "내이벌은 새롭게 밀고있는 신개념 문자 시스템을 개발에 성공하였다고 발표하였으며 외부 해킹 및 보안 유출에 월등히 개선되었다고 알렸습니다.", 1, 0.2f, 20));
        newsDataList.Add(new News(100, "신문", "삼숭이 전문 헤드셋 업체 빗츠를 인수한다고 밝히며 향후 이어폰 및 스피커 품질에 대한 획기적 개선이 기대된다고  발표하였습니다.", 0, 0.25f, 20));
        newsDataList.Add(new News(100, "신문", "MC소프트가 보안 솔루션 전문 업체인 안드랩을 인수하고 블록체인 사업에 대규모 투자를 감행할것이라고 밝혔습니다.", 2, 0.25f, 20));
        newsDataList.Add(new News(100, "신문", "MC소프트는 최근들어 개인정보 등 보안 관련된 많은 사회적 이슈에 선제적 대응을 위해 500억달러 가량의 투자를 진행한다고 발표했습니다.", 2, 0.25f, 20));
        newsDataList.Add(new News(100, "신문", "삼숭은 차세대 결제 서비스로 간편 결제를 제공하기 위해 간편결제 관련 스타트업체를 300억달러에 인수하고 대규모 투자를 진행할 것이라 발표했습니다.", 0, 0.25f, 20));
        newsDataList.Add(new News(100, "신문", "내이벌는 통신업체 SLK과 전략적 협력관계를 맺고 상호간에 1 % 의 주주거래를 진행한다고 발표했습니다.관련업체들은 기대되는 협력관계라며 입을 모았습니다.", 1, 0.2f, 20));
        newsDataList.Add(new News(100, "신문", "삼숭은 전년도 출시 제품의 출하량이 3000만대에 달하며 역대 제품 매출 순위를 경신하였다고 밝혔습니다.", 0, 0.2f, 20));
        newsDataList.Add(new News(100, "신문", "삼숭은 당해년도 주력 제품의 출하량이 매우 눈에 띄게 높으며 지속적으로 유지되고있다고 밝히며 높은 영업이익률이 기대된다고 평가했습니다.", 0, 0.2f, 20));
        newsDataList.Add(new News(100, "신문", "MC소프트의 전략 플래그십 제품의 상반기 출하량이 기대 이상으로 높아 영업이익률이 대폭 향상될 것으로 예상됩니다.", 2, 0.2f, 20));
        newsDataList.Add(new News(100, "신문", "국토교통부는 삼숭에서 수입,판매한 총 7개 제품 2만 285대에서 제작 결함이 발견돼 시정조치(리콜)한다고 밝혔다.", 0, -0.1f, 40));
        newsDataList.Add(new News(100, "신문", "삼숭의 스마트폰 발화요인에 대해 정부 역시 A사에서 이미 발표한 것처럼 배터리에 문제가 있었던 것으로 파악했습니다. 삼숭은 즉각적으로 판매중지 및 리콜을 시행한다고 밝혔습니다.", 0, -0.05f, 40));
        newsDataList.Add(new News(100, "신문", "MC소프트에서 당해년도에 출하한 제품에 심각한 기계적 결함이 있음을 인정하고 출하를 앞둔 약 300만대에 이르는 제품을 모두 리콜하고 판매완료된 상품에 대해선 보상한다고 발표했습니다.", 2, -0.3f, 30));
        newsDataList.Add(new News(100, "신문", "MC소프트에서 전해년도에 출하한 제품에 심각한 소프트웨어결함이 있음을 인정하고 출하를 앞둔 약 100만대에 이르는 제품을 모두 리콜하고 판매완료된 상품에 대해선 보상한다고 발표했습니다.", 2, -0.3f, 30));
        newsDataList.Add(new News(100, "신문", "내이벌에서 지난 5년간 출하한 제품에 대해 심각한 내부적결함이 있음을 인정하고 약 100만대에 이르는 출하전 제품을 모두 리콜하고 판매제품 소지후 방문시 교체를 진행한다고 발표했습니다.", 1, -0.3f, 30));
        newsDataList.Add(new News(100, "신문", "내이벌의 SNS 이용자 약 2억 6천 7백만명의 개인정보가 유출됐다고 AP와 로이터 통신 등이 보도했습니다.", 1, -0.15f, -40));
        newsDataList.Add(new News(100, "신문", "검찰 고위 관계자에 따르면 삼숭의 신제품 개발 부서내 플래그쉽전략실에서 공들여 개발중이였던 프로젝트의 핵심 부품을 퍄모 씨 등 3명의 일당이 경쟁기업에 팔아넘기는 행위를 파악하여 구속하였다고 보도했습니다.", 0, -0.3f, 50));
        newsDataList.Add(new News(100, "신문", "내이벌에서 새로 출시한 제품에 내부적 결함을 출시전에 발견하였음에도 불구하고 소비자들은 다 개돼지다라며 출시를 강행한 사실이 발각되어 검찰이 수사에 착수 하였습니다.", 1, -0.3f, 40));
        newsDataList.Add(new News(100, "신문", "경기도 안양시에 위치한 MC소프트의 데이터센터가 폭우로 침수가 발생하여 데이터 복구작업에 착수중이라고 발표하였습니다.", 2, -0.2f, -30));
        newsDataList.Add(new News(100, "신문", "삼숭에서 일반인 대상 견학 페이지를 성공적으로 제작했다. 앞으로 관련 직종에 종사하고 싶은 청소년을 위하여 견학 페이지를 통해 무료 교육을 제공한다고 발표했다. 이에 많은 투자자가 지지 의사를 남겼다.", 0, 0.3f, 40));
        newsDataList.Add(new News(100, "신문", "내이벌의 새로운 대표 취임식이 열렸다. 이 날 취임된 새로운 대표 ‘채벼리’씨는 대한민국 10대 CEO로 꼽히는 저명한 인물이다.이에 따른 앞으로의 F그룹의 행보가 기대된다. ", 1, 0.3f, 30));
        newsDataList.Add(new News(100, "신문", "MC소프트 자사의 악성 메일 링크를 통한 랜섬웨어가 성행하고 있다. 경찰은 이와 같은 신고가 현재까지 수십만건에 이른다고 전해졌다. 새로운 형태의 악성 메일이 계속 생겨나고 있으니 메일을 열기 전 보안 프로그램을 설치하는 것으로 랜섬웨어를 막아야 할 것이다.", 2, -0.2f, 20));
        newsDataList.Add(new News(100, "신문", "MC소프트 이 악성코드 FCG의 진단율 100 % 로 KGC인증 마크를 획득했다.F그룹 대표는 막중한 책임감을 느낀다며 새로운 악성코드 진단에도 힘쓰겠다고 말했다. ", 2, 0.2f, 30));
        newsDataList.Add(new News(100, "신문", "MC소프트 이 새로운 보안 시스템을 도입한 김랩연구소2.0을 출시했다. F그룹은 출시 이후에도 안전 시스템을 지속적으로 업데이트 할 것을 약속했다.", 2, 0.3f, 40));
        newsDataList.Add(new News(100, "신문", "내이벌이 선거 개입을 했다는 사실이 검찰에 의해 드러났다. ", 1, -0.3f, 40));
        newsDataList.Add(new News(100, "신문", "삼숭 직원이 삼숭의 보안 프로그램 ‘김랩연구소’가 상술이라며 폭로했다.바이러스가 없어도 있는 것처럼 꾸며 돈을 벌고 있다는 내용이다. ", 0, -0.3f, 40));
        newsDataList.Add(new News(100, "신문", "삼숭의 ‘디지털 장의사’ 프로그램이 음란물 제작사 - 유포사와 카르텔을 맺고 있었다는 사실이 검찰에 의해 드러났다.음란물 피해여성이 F그룹에게 문의를 할 때 음란물 제작사 김모씨와 긴밀하게 협조를 하고 있었다는 내용이다. ", 0, -0.3f, 30));
        newsDataList.Add(new News(100, "신문", "내이벌의 보안 프로그램이 오히려 보안 공격의 대상이 된다는 사실이 밝혀졌습니다.해킹 그룹 ‘노토리어스’가 내이벌 보안 프로그램 사용자를 대상으로 하여 개인정보를 수집한다고 밝혔습니다.", 1, -0.4f, 40));
        newsDataList.Add(new News(100, "신문", "MC소프트가 ‘갑질 논란’에 휩싸였다. 하청 업체에서 근무하는 A씨는 MC소프트의 무리한 프로젝트 요구와 폭언에 폭로를 결정했다고 밝혔다.", 2, -0.3f, 30));


        /*패션 브랜드*/

        newsDataList.Add(new News(100, "신문", "미국 플로리다주에 위치한 로뤠알의 생산공장에 태풍급 허리케인의 영향으로 인해 생산 중단에 들어갔다고 발표하였습니다.", 3, -0.1f, 30));
        newsDataList.Add(new News(100, "신문", "강원도 인제군에 위치한 샤날의 생산공장에서 북한의 남파공작원의 적대행위로 인해 정전이 일어나 생산량에 차질이 생겼다고 발표했습니다.", 4, -0.1f, 30));
        newsDataList.Add(new News(100, "신문", "명품브랜드 그룹 로뤠알이 미국 보석업체 티퐈니 인수 절차를 오늘 마무리지을 것으로 보인다.", 3, 0.3f, 30));
        newsDataList.Add(new News(100, "신문", "‘복싱의 전설’이라 불리는 미국의 세계적인 권투선수 메이웨더의 패션이 화제다. 메이웨더가 입은 셔츠와 가방은 명품 브랜드 로뤠알가 지난 1월 출시한 제품으로 공식 홈페이지에 따르면 셔츠는 990만원, 가방은 560만원에 이른다. 하지만 어마어마한 가격에도 해당 셔츠는 품절 상태다.", 3, 0.3f, 40));
        newsDataList.Add(new News(100, "신문", "지난해 12월 세계적인 명품 브랜드 샤날가 스트릿 브랜드 최강자인 ‘나이키 에어 조던’이 만나 화제를 모았던 적이 있다. 어제 저녁, 정가 245만원에서 리셀가 3800만원으로 판매됐다. ", 4, 0.3f, 40));
        newsDataList.Add(new News(100, "신문", "가수 혀놔와 꾸뛰르 코스메틱 브랜드 입상로랑가 함께 한 새로운 디지털 뷰티 화보가 공개됐다." ,5, 0.3f, 30));
        newsDataList.Add(new News(100, "신문", "배우 하녜슬 씨가 바른 레드 컬러의 틴트가 화제다.지난 4일 하녜슬씨는 자신의 인스타그램에 틴트를 바르는 영상을 올렸다. 클레오파트라처럼 일자 앞머리를 하고 빨간 틴트를 바르는 모습은 단박에 시선을 끌었다.해당 제품은 로뤠알의 신제품으로 알려졌다.", 3, 0.3f, 30));
        newsDataList.Add(new News(100, "신문", "샤날가 총 평판지수의 소폭 하락률을 보이며, 입상로랑에게 아주 근소한 격차로 2위 자리를 양보했다.한국기업평판연구소(소장 구창환)는 “소비자들에게 사랑받는 향수 브랜드에 대해 2020년 3월 21일부터 2020년 4월 22일까지의 향수 브랜드 빅데이터 31,875,775개를 분석하여 소비자들의 브랜드 습관과 평판을 분석한 결과, 샤날가 3위를 차지했다”고 밝혔다.", 4, -0.1f, 10));
        newsDataList.Add(new News(100, "신문", "명품업체 입상로랑가 YG엔터테인먼트로부터 600억원대 투자금을 회수하고도 투자 손실을 피하지 못한 것으로 나타났다.이는 YG 주가 하락의 타격이 됐다.", 5, -0.2f, 30));
        newsDataList.Add(new News(100, "신문", "제보자 강모 시는 로뤠알에서 구매한 핸드백의 버클에 양면테이프가 붙어있었다고 제보했다.곧바로 로뤠알 고객센터에 항의했지만, 오히려 로뤠알는 오히려 강씨를 블랙컨슈머 취급을 했다고 한다. ", 3, -0.4f, 40));
        newsDataList.Add(new News(100, "신문", "‘곰팡이호박즙’ 사건으로 논란에 올랐던 샤날 화장품을 산 소비자들의 손해배상 청구 소송에서 패소했다.서울중앙지법 민사합의24부(부장판사 이석재)는 샤날 화장품 소비자 이모씨 등 37명이 샤날을 상대로 낸 3억 7,000만원의 손해배상 청구 소송에서 지난 22일 원고 승소 판결을 내렸다. ", 4, -0.4f, 40));
        newsDataList.Add(new News(100, "신문", "로뤠알의 디자이너 총괄 책임자가 트위터에 혁신적이고, 충격적이며, 놀랍다는 글을 올려 많은 사람들의 주목을 받고 있습니다.", 3, 0.1f, 20));
        newsDataList.Add(new News(100, "신문", "샤날 총괄 디자이너로 경쟁기업의 수석 디자이너를 영입했다고 발표했습니다.해당 수석 디자이너는 경쟁사에서 주력 제품 담당자였던 만큼 관심이 쏠리고 있습니다 ", 4,  0.2f, 20));
        newsDataList.Add(new News(100, "신문", "로뤠알가 경영고문으로 전문 경영인을 구한다고 발표하였습니다.이에 실적 개선 기대감이 높아지고 있습니다 ", 3, 0.1f, 20));
        newsDataList.Add(new News(100, "신문", "샤날의 광고 기획 담당부서에서 광고계의 천재 아티스트라 불리는 광드레드 앙을 고문으로 섭외하였다는 소식이 전해졌습니다", 4, 0.1f, 20));
        newsDataList.Add(new News(100, "신문", "입상로랑가 주 경쟁사와의 치킨게임을 멈추고 상호 협력적인 관계를 유지하며 선의의 경쟁을 하며 불법적 스파이 행위를 근절하겠다고 발표했습니다.", 5, 0.2f, 20));
        newsDataList.Add(new News(100, "신문", "로뤠알가 새해 신년 인사로 사회적 기업으로 다시 태어나는해가 될것이라며 노사, 하청간의 동반적 성장을 목표로 한다고 발표했습니다.", 3, 0.1f, 20));
        newsDataList.Add(new News(100, "신문", "샤날 회장은 노블리스 오블리제는 기업으로서의 의무와 책무라며 매출액의 일정 비율을 사회에 지속적으로 환원할 것이라고 발표했습니다.", 4, 0.1f, 20));
        newsDataList.Add(new News(100, "신문", "매년 사회적으로 공공의 모범이 되는 인물들에게 입상로랑가 장학금 및 상장을 수여하고 있는 사실이 뒤늦게 드러나 많은 사람들이 애국기업이라며 검색어 올리기 운동을 하고있습니다.", 5, 0.1f, 20));
        newsDataList.Add(new News(100, "신문", "로뤠알의 회장의 장녀가 국내 대학의 특별 입학전형을 거부하고 일반 전형을 통해 대학에 진학하여 사람들에게 긍정적인 반응을 얻고 있습니다.", 3, 0.1f, 20));
        newsDataList.Add(new News(100, "신문", "샤날 회장의 막내아들이 해병대에 자원 입대하고 최근에 병장으로 만기 전역하여 많은 사람들의 모범이 되었다는 평가가 이뤄지고 있습니다.", 4, 0.1f, 20));
        newsDataList.Add(new News(100, "신문", "입상로랑의 식단 제공 업체가 어려운 국내 농산물 시장에 도움을 주고자 모든 식자재를 국내산으로 변경한다고 하여 많은 농가들의 지지를 받고있습니다.", 5, 0.1f, 20));
        newsDataList.Add(new News(100, "신문", "로뤠알가 최근 불법적 성매매 이슈에 관련된 직원들을 선제적 대응으로 모두 정리해고하였다고 밝혔습니다.", 3, 0.15f, 20));
        newsDataList.Add(new News(100, "신문", "샤날은 사내 성추행 사건에 대해 매우 공정하고 엄격한 판단을 내리고 있어 내부 직원들의 애사심이 더욱 투철해 졌다고 고위 관계자는 밝혔습니다.", 4, 0.15f, 20));
        newsDataList.Add(new News(100, "신문", "입상로랑는 직장내 괴롭힘 및 무분별한 직원 하대에 대해 무관용의 원칙으로 처벌하고 선진적인 사내 문화를 형성하는데 앞서겠다고 발표했습니다.", 5, 0.15f, 20));
        newsDataList.Add(new News(100, "신문", "로뤠알는 수직적 사내 문화를 탈피하고 수평적이고 자유로운 사내문화 형성을 위해 직책을 대규모 통합한다고 밝혔습니다.", 3, 0.15f, 20));
        newsDataList.Add(new News(100, "신문", "샤날의 고위 관계자에 따르면 최근 실시한 직원 만족도 및 애사심 평가에서 긍정평가부문이 전년도 비 20 % 상승했다고 밝혔습니다.", 4, 0.25f, 20));
        newsDataList.Add(new News(100, "신문", "입상로랑가 정기 부정부패 측정 평가에서 매우 높은 고득점을 받았다고 밝혔습니다.", 5, 0.25f, 20));
        newsDataList.Add(new News(100, "신문", "로뤠알는 새로 출시한 제품의 판매량이 전작 대비 30 % 향상 되었다고 밝혔으며, 외부기관들은 로뤠알의 실적개선이 이뤄질거라 평가하였습니다.", 3, 0.3f, 20));
        newsDataList.Add(new News(100, "신문", "샤날은 최근 발생한 대규모 바이러스 사태에 따른 수요 급감에도 불구하고 매출액 및 손익부분에서 크게 선방하였음이 드러났습니다.", 4, 0.2f, 20));
        newsDataList.Add(new News(100, "신문", "입상로랑는 5년간 지속되었던 손익부문 만성 적자에서 탈출에 성공하였으며 눈에 띄는 실적 개선이 이뤄졌다고 밝혔습니다.", 5, 0.3f, 20));
        newsDataList.Add(new News(100, "신문", "로뤠알의 상반기 재무제표가 매우 개선된 수준으로 나와 임직원에 대해 대규모 인센티브를 제공한다고  밝혔습니다.", 3, 0.2f, 20));
        newsDataList.Add(new News(100, "신문", "샤날의 하반기 매출 및 손익 실적 발표에서 기대이상의 수준으로 나타나 추가 투자자들의 발길이 이어지고 있습니다.", 4, 0.2f, 20));
        newsDataList.Add(new News(100, "신문", "입상로랑 부사장이 지난 5일(현지시간) 미국 JFK 국제공항에서 인천으로 출발하는 대항항공 KE086편 항공기를 '램프리턴(승객의 안전에 문제가 생겼을 경우 취하는 조치)' 했다.", 5, -0.3f, 30));
        newsDataList.Add(new News(100, "신문", "로뤠알 전무가 광고대행 업체와의 회의 자리에서 대행사 직원에게 물을 뿌렸다는 의혹", 3, -0.1f, 30));
        newsDataList.Add(new News(100, "신문", "수행기사들에게 불법 운전을 지시한 강요죄와 전문의약품인 ‘센돔’을 지인들에게 양도한 약사법 위반 등의 혐의로 샤날 회장을 불구속 기소 의견으로 검찰에 송치했다", 4, -0.20f, 30));
        newsDataList.Add(new News(100, "신문", "입상로랑 회장의 셋째 아들이 술집 종업원을 폭행하는 사건이 일어났습니다.", 5, -0.05f, 30));
        newsDataList.Add(new News(100, "신문", "한국 산재협의회에 따르면 로뤠알에서 근무한 뒤 병을 얻어 사망에 이르는 산업재해가 지속적으로 발생하고 있다고 한다. 산업안전보건연구원은 이 의혹에 대해 역학조사를 실시하였다.", 3, -0.05f, 30));
        newsDataList.Add(new News(100, "신문", "샤날 창업주의 3세에게 마약을 제공했다고 한 이모(30)씨가 2일 오후 9시쯤 마약수사대 사무실로 자진출석 했다고 밝혔다.", 4, -0.1f, 30));
        newsDataList.Add(new News(100, "신문", "액상 대마를 밀수해 흡연한 혐의로 입상로랑 회장의 차남인 허모 전 부사장이 징역 3년과 집행유예 4년을 선고받았다.", 5, -0.15f, 30));
        newsDataList.Add(new News(100, "신문", "로뤠알 노조가 그간 암암리에 있었던 인사 청탁 문제를 폭로하겠다는 입장을 내놨습니다.", 3, -0.05f, 30));
        newsDataList.Add(new News(100, "신문", "입상로랑의 디자이너 A씨가 타 유명브랜드 가방 디자인 표절논란에 쉽싸였다. 다지이너 A씨는 아니라고 해명했지만 많은 누리꾼들의 화를 샀다..", 5, -0.2f, 30));
        newsDataList.Add(new News(100, "신문", "입상로랑은 올해의 컬러 클래식 블루를 테마로 한 패션쇼를 선보였다. 전문가는 올해 트렌드를 가장 잘읽는 브랜드라며 칭찬을 아끼지 않았다", 5, 0.15f, 30));
        

        /*영화드라마*/

        newsDataList.Add(new News(100, "신문", "디쥬니 대표이사와 그 일동들이 그동안 유흥업소에 지속적으로 방문했던 사실이 밝혀졌다. 또 대표이사가 연예인 지망생을 꼬드겨 성매매를 강요한 사실이 드러났다.이에 경찰은 구속영장을 발부하여 대표이사 A씨를 체포했다.", 6, -0.4f, 40));
        newsDataList.Add(new News(100, "신문", "2달 전 개봉한 영화 ‘바퀴벌레’가 미국 유명 영화제에서 4관왕을 수상했다. 이는 매우 이례적인 일이라며 마뷸 스튜디오 앞으로 영화를 새롭게 드라마화할 것을 약속했다.", 7, 0.4f, 40));
        newsDataList.Add(new News(100, "신문", " 워너시스터즈의 이번 주 새로운 영화 ‘헤드폰’을 개봉할 예정이다.이 영화는 유명 배우 ‘벼리’씨가 제작에 참여한 것으로 알려져 많은 네티즌을 기대를 얻고 있다.", 8, 0.3f, 30));
        newsDataList.Add(new News(100, "신문", " 디쥬니에서 제작한 드라마 ‘내인생은 내꺼’가 2회만에 시청률 30 % 를 기록했다.참신한 스토리와 배우의 연기력이 앞으로의 남은 18회 드라마에 기대를 걸게 만든다.", 6, 0.3f, 30));
        newsDataList.Add(new News(100, "신문", " 마뷸 스튜디오 유명 영화 감독 ‘나유명’씨가 합류하기로 최종 결정되었다. I사는 앞으로의 영화 산업에서의 활약을 부탁한다며, 이번 달 부터 새로운 영화 제작을 시작한다고 밝혔다.", 7, 0.2f, 30));
        newsDataList.Add(new News(100, "신문", " 워너시스터즈의 학교를 소재로 한 웹드라마가 요즘 10대들 사이에서 화제다.해당 웹드라마 패러디와 배우가 착용한 옷차림, 헤어 스타일이 고등학생들 사이에서 유행하고 있다.", 8, 0.3f, 30));
        newsDataList.Add(new News(100, "신문", " 디쥬니가 대형 영화관 스크린 독점을 위해 영화관 대표 A씨와 B씨에게 수억원대의 뇌물을 준 정황이 확인되었다. 경찰은 이에 대해 면밀히 수사할 것임을 강조했다.", 6, -0.2f, 30));
        newsDataList.Add(new News(100, "신문", " 꼬로나 전염병의 여파로 영화계에 갈등이 일어나고 있다. 많은 사람이 모이는 영화관에 가지 말자는 보이콧까지 벌어지면서 당초 이번 달 개봉 예정인 영화가 5달 뒤로 미뤄지게 되었다.", 6, -0.4f, 40));
        newsDataList.Add(new News(100, "신문", " 마뷸 스튜디오의 드라마의 여자 주인공 캐스팅 문제로 편성이 불발되었다. 이에 A씨는 ‘왜 약속을 안 지킬까요?’ 라는 글을 SNS에 남겨 I사에 대한 불만을 토로했다.", 7, -0.3f, 40));
        newsDataList.Add(new News(100, "신문", " 워너시스터즈의 드라마 제작 스태프가 자동차 추격전 촬영 현장에서 무리한 촬영을 진행하다가 척추뼈가 으스러지는 중상을 입었다. 이에 A씨는 기자회견을 열고 I사의 무리한 제작 현장에 대해 고발했다.", 8, -0.3f, 30));
        newsDataList.Add(new News(100, "신문", " 디쥬니에서 제작한 영화 XXX이 미국 아카데미를 정복했다. 1일(현지시각) 오후 미국 로스앤젤레스 할리우드 돌비극장에서 열린 제 80회 아카데미 시상식에서 영화 XXX이 아카데미상 작품상을 수상하는 쾌거를 기록했다.", 6, 0.3f, 30));
        newsDataList.Add(new News(100, "신문", " 마뷸 스튜디오의 사회공헌 프로그램의 하나로 드라마, 영화 신인작가 40명을 선발해 창작과 데뷔를 지원한다.마뷸은 10일 마포구 상암동 동아디지털미디어센터에서 신인 작가 창작 공간으로 쓰일 ‘미래’ 센터 개관 기념 기자간담회를 열고 미래 사업에 올해부터 2030년까지 총 130억원을 투자한다고 밝혔다.", 7, 0.2f, 30));
        newsDataList.Add(new News(100, "신문", " 배우 XXX의 불륜설이 터진 가운데 워너시스터즈에서 제작한 드라마 000도 곤혹을 치르고 있다. XXX은 9일 첫 방송된 BSB 새 월화드라마 000에 출연하고 있기에 000도 난감한 상황에 빠졌다. 이번 뷸륜 논란이 삼일째 이어지고 있지만 XXX측도, 000측도 추가적인 입장은 내놓고 있지 않다.", 8, -0.3f, 40));
        newsDataList.Add(new News(100, "신문", " 콘텐츠 강자인 디쥬니가 영화 시장에서 힘을 못쓰고 있다.디쥬니는 지난해 배급한 영화들이 저조한 흥행 실적을 거두면서 10년간 지켜온 영화 시장 1위 자리를 경쟁사 XXX에 내줬다.", 6, -0.3f, 30));
        newsDataList.Add(new News(100, "신문", " 마뷸 스튜디오에서 제작한 드라마 스태프들이 과로사하여 문제가 되고 있다. ", 7, -0.4f, 40));
        newsDataList.Add(new News(100, "신문", " 워너시스터즈에서 제작한 영화 스태프 중 몇 명이 이른바 ‘갑질’로 인한 피해를 폭로해 이슈가 되었다.", 8, -0.4f, 40));
        newsDataList.Add(new News(100, "신문", " 디쥬니에서 제작한 드라마 스태프들이 임금을 제 때 받지 못해 문제가 되고 있다.", 6, -0.3f, 40));
        newsDataList.Add(new News(100, "신문", " 마뷸 스튜디오에서 제작한 기대작 영화 ‘프렌즈' 가 흥행참패하였다.", 7, -0.3f, 30));
        newsDataList.Add(new News(100, "신문", " 워너 시스터즈의 기대작인 드라마 ‘부부는 세명' 이 자극적인 장면으로 인해 심의에 걸려 문제가 되었다.", 8, -0.1f, 20));
        newsDataList.Add(new News(100, "신문", " 기대주인 배우 ‘규리' 가 출연한 디쥬니의 드라마 ‘너는 나의 귤귤귤' 이 흥행참패하였다.", 6, -0.1f, 20));
        newsDataList.Add(new News(100, "신문", " 마뷸 스튜디오의 기대작인 영화 ‘너는 내 운명일까'에 출연한 배우 ‘문제임' 이 음주 운전으로 논란이 되고 있다.", 7, -0.2f, 20));
        newsDataList.Add(new News(100, "신문", " 워너 시스터즈에서 제작한 드라마 ‘하늘 캐슬'이 흥행에 성공하여 유명세를 타고 있다.", 8, 0.3f, 30));
        newsDataList.Add(new News(100, "신문", " 디쥬니에서 제작한 영화 ‘하늘이 맑아요'가 해외에서 긍정적인 평가를 받고 있다.", 6, 0.2f, 20));
        newsDataList.Add(new News(100, "신문", " 기대주인 배우 ‘듀리' 가 출연한 마뷸 스튜디오의 드라마 ‘우리 듀리'가 흥행에 성공하였다.", 7, 0.3f, 20));
        newsDataList.Add(new News(100, "신문", " 워너시스터즈에서 제작한 드라마 ‘상속자' 에서 나온 패션들이 유행하고 있다.", 8, 0.2f, 20));
        newsDataList.Add(new News(100, "신문", " 디쥬니의 대표이사가 마약 혐의로 검찰에 송치되었다. ", 6, -0.3f, 40));
        newsDataList.Add(new News(100, "신문", " 마뷸 스튜디오의 기대작인 영화 ‘운명' 에 출연한 배우 ‘이상해' 씨가 마약 혐의로 검찰에 송치되어 영화 개봉이 미뤄졌다.", 7, -0.4f, 40));
        newsDataList.Add(new News(100, "신문", " 워너시스터즈의 기대작인 드라마 ‘기대중' 에 출연중인 배우 ‘안다쳐' 씨가 촬영장 내에서 부상을 입어 논란이 되고 있다.", 8, -0.3f, 40));
        newsDataList.Add(new News(100, "신문", " 디쥬니 대표 이사가 뇌물 혐의로 인해 검찰에 송치되었다.", 6, -0.3f, 30));
        newsDataList.Add(new News(100, "신문", "마뷸 스튜디오의 영화 ‘비오는 날에' 가 부정적인 평가에도 불구하고 흥행에 성공하였다.", 7, 0.4f, 40));
        newsDataList.Add(new News(100, "신문", "다음 주 워너시스터즈에서 개봉되는 영화에 유명 성우 A씨가 작품을 같이 한다고 하여 화제.", 8, 0.2f, 30));
        newsDataList.Add(new News(100, "신문", "이번에 개봉한 디쥬니의 영화에 인종 차별적 대사가 포함되어 있어 네티즌에 큰 비난을 받고 있다.", 6, -0.25f, 30));

        /*음식점*/
        newsDataList.Add(new News(100, "신문", "아웃벨 00매장에서 판매직원들의 고객의 신체적특징을 비하하고 희화화하는 행위가 발각되어 소비자들의 불매운동 조짐이 나타나고 있습니다.", 9, -0.2f, 30));
        newsDataList.Add(new News(100, "신문", "전지구적으로 바이러스가 창궐하여 사회적 거리두기가 시행되어 파머스 판매점 절반을 닫는다고 발표하였습니다.", 10, -0.3f, 30));
        newsDataList.Add(new News(100, "신문", "울워즈 매장에서 고객의 외모특징을 특정 동물에 빗대어 비하한 행위를 알바생이 폭로하여 소비자들의 불매운동 조짐이 나타나고 있습니다.", 11, -0.2f, 30));
        newsDataList.Add(new News(100, "신문", "아웃벨매장에서 10년간 일해온 김모씨가 고객들의 적립 포인트를 빼돌려 자신의 적립카드에 적립한 행위가 발각되었지만 개인의 일탈이라며 방관하는 회사의 무책임한 태도에 소비자들의 비난 여론이 확산중에 있습니다.", 9, -0.2f, 30));
        newsDataList.Add(new News(100, "신문", "파머스의 통조림 제품에서 벌레가 나왔음에도 소비자 과실이라며 방관적인 태도를 취하였다는 제보를 받았습니다.", 10, -0.3f, 30));
        newsDataList.Add(new News(100, "신문", "울워즈에서 운영하는 국수 전문점 XXX가 봄을 맞이해 입맛을 돋우는 봄 신메뉴를 출시한다고 4일 밝혔다. 이번 신메뉴 콘셉트는 얼큰 고기국수와 참치 비빔면 2종이다.신메뉴 국수 2종은 배달이 가능해 집, 회사 등 어디서든 즐길 수 있다.", 11, 0.3f, 40));
        newsDataList.Add(new News(100, "신문", "아웃벨 중국 지부가 현지 펀드와 합작법인을 설립한다. 아웃벨 이번 계약으로 얻은 1000억을 활용해 중국 사업 재무구조가 크게 개선될 것으로 기대하고 있다. 또한 이를 토대로 빠르게 성장할 것으로 보고 있다고 말했다. ", 9, 0.3f, 30));
        newsDataList.Add(new News(100, "신문", "파머스 등 유명 카페 프랜차이즈 매장 8곳 가운데 1곳이 조리대가 불결하거나 유통기한이 지난 재료를 사용하는 것으로 밝혀졌다.식약처가 보름동안 카페 프랜차이즈 업체를 점검한 결과, 8곳 중 1곳은 식품위생법을 위반한 것으로 나타났다.가장 많이 적발된 사례는 조리장 위생불량이었다.", 10, -0.3f, 30));
        newsDataList.Add(new News(100, "신문", "가맹점주를 상대로 수년간 갑질 행위를 한 혐의를 받는 울워즈 창업주 우러주 회장이 1시멩서 집행유예를 선고받고 풀려났다. ", 11, -0.3f, 40));
        newsDataList.Add(new News(100, "신문", "뇌물수수와 횡령 등의 혐의로 재판에 넘겨진 아웃벨 대표, 검찰이 20년 구형했다.", 9, -0.3f, 40));
        newsDataList.Add(new News(100, "신문", "서울지방국세청이 조세포탈 혐의로 파머스 회장을 검찰에 고발하면서 시작됐다. 고발장을 접수한 서울남부지검은 기업·금융범죄전담 부인 형사6부에 사건을 배당해 조사에 본격 착수했다. 검찰은 지난해 6월 조 회장을 피의자 신분으로 처음 소환해 약 16시간에 걸친 고강도 조사를 벌인 뒤 7월초 구속영장을 청구했다.", 10, -0.25f, 40));
        newsDataList.Add(new News(100, "신문", "울워즈 발표에 따르면 조 회장이 이날 새벽 미국 현지에서 폐질환으로 별세했다. ", 11, -0.1f, 40));
        newsDataList.Add(new News(100, "신문", "아웃벨 전 CEO, A씨가 사망했다고 아웃벨 공식발표했다. A씨는 아웃벨 핵심 인물이며, 몇 년째 췌장암으로 투병해왔다.", 9, -0.5f, 40));
        newsDataList.Add(new News(100, "신문", "파머스 기밀부서인 미래전략기획실에서 극비리에 개발중인 프로젝트의 핵심 기술을 조모 씨 외 2명의 일당이 중국으로 유출한것이 드러났습니다.", 10, -0.25f, 50));
        newsDataList.Add(new News(100, "신문", "검찰은 울워즈 신제품 개발 부서인 4차산업 전략기획실에서 야심차게 개발중인 프로젝트의 핵심 기술을 야모 씨 외 2명의 일당이 일본으로 유출한 정황을 파악했다고 발표했습니다.", 11, -0.25f, 50));
        newsDataList.Add(new News(100, "신문", "아웃벨 고위 관계자에 따르면 아웃벨 법률 자문 위원회에서 탈세법을 위반한 혐의로 수사중에 있다고 전해왔습니다.", 9, -0.3f, 40));
        newsDataList.Add(new News(100, "신문", "파머스 고위 관계자로부터 파머스내 후계자 계승에 따른 상속세에 대한 탈세를 목적으로 주가 조작행위를 조직적으로 벌인 행위에 대한 폭로를 할것이라는 공익 제보가 있었습니다.", 10, -0.3f, 40));
        newsDataList.Add(new News(100, "신문", "검찰 내부 소식통에 의하면 울워즈내에서 대규모의 조직적 탈세행위를 포착하여 수사에 착수한다고 알려왔습니다.", 11, -0.35f, 40));
        newsDataList.Add(new News(100, "신문", "아웃벨 사외이사 조모씨가 회식자리에서 여사원에게 접대를 강요했다는 제보가 들어와 경찰이 수사에 착수했습니다.", 9, -0.1f, 30));
        newsDataList.Add(new News(100, "신문", "파머스의 회장 강모씨의 셋째 아들이 성매매 이슈에 휩싸여 논란이 일고있습니다.", 10, -0.2f, 30));
        newsDataList.Add(new News(100, "신문", "울워즈 부회장이 차량 전용 기사에게 상습적인 성추행 및 욕설을 일삼와 왔다는 사실에 많은 사람들이 분개하고있습니다.", 11, -0.3f, 30));
        newsDataList.Add(new News(100, "신문", "아웃벨 고위 임원의 둘째 아들이 음주운전을 하고난 후 운전자 바꿔치기를 하고 도주했음에도 불구속 처분을 받아 비난여론이 매우 들끓고있습니다.", 9, -0.3f, 30));
        newsDataList.Add(new News(100, "신문", "파머스의 고위 임원이 상습적으로 부하직원들에게 성휘롱 및 손찌검을 일삼았다는 제보가 들어와 경찰이 수사에 착수했습니다.", 10, -0.3f, 30));
        newsDataList.Add(new News(100, "신문", "울워즈 전략 플래그십 제품의 상반기 출하량이 기대에 비해 매우 저조한것으로 드러나 영업이익률이 대폭 축소될 것으로 예상됩니다.", 11, -0.2f, 20));
        newsDataList.Add(new News(100, "신문", "아웃벨 상반기 재무제표가 처참한 수준으로 드러나 임원급 인사에 대해 대규모 물갈이를 해야한다는 회사내 여론이 확산되고 있습니다.", 9, -0.2f, 20));
        newsDataList.Add(new News(100, "신문", "파머스의 하반기 매출 및 손익 실적 발표에서 기대이하의 수준으로 나타나자 투자자들의 회의론이 퍼지고 있습니다.", 10, -0.2f, 20));
        newsDataList.Add(new News(100, "신문", "울워즈는 재무 건정성 확보를 위해 적자부분 사업을 정리하고 유망 사업 분야에 적극적 투자를 진행한다고 밝혔습니다.", 11, 0.2f, 20));
        newsDataList.Add(new News(100, "신문", "아웃벨 신종 코로나 바이러스로 인한 국가적 위기상황에 대한 사회적 기업 책무를 다하기 위해 손세정제 및 마스크를 무료배포한다고 발표했습니다.", 9, 0.2f, 20));
        newsDataList.Add(new News(100, "신문", "파머스는 최근 불법적 성매매 이슈에 관련된 직원들을 선제적 대응으로 모두 파면하였다고 밝혔습니다.", 10, 0.15f, 20));
        newsDataList.Add(new News(100, "신문", "울워즈는 사내 성추행 사건에 대해 매우 공정하고 엄격한 판단을 내리고 있어 내부 직원들의 애사심이 더욱 투철해 졌다고 고위 관계자가 밝혔습니다.", 11, 0.15f, 20));
        newsDataList.Add(new News(100, "신문", "아웃벨 직장내 괴롭힘 및 무분별한 무력행위에 대해 무관용의 원칙으로 처벌하고 선진적인 사내 문화를 형성하는데 앞서겠다고 발표했습니다.", 9, 0.15f, 20));
        newsDataList.Add(new News(100, "신문", "파머스는 수직적 사내 문화를 탈피하고 수평적이고 자유로운 사내문화 형성을 위한 조례 신설 및 직급 부문에 대해 대규모 통합을 진행한다고 밝혔습니다.", 10, 0.15f, 20));
        newsDataList.Add(new News(100, "신문", "울워즈의 내부 관계자에 따르면 최근 실시한 직원 만족도 및 애사심 평가에서 긍정부문에서 전년도 비 30 % 상승했다고 밝혔습니다.", 11, 0.25f, 20));
        newsDataList.Add(new News(100, "신문", "아웃벨 연말에 실시한 정기부정부패 측정 평가에서 매우 높은 점수를 받았다고 밝혔습니다.", 9, 0.25f, 20));
        newsDataList.Add(new News(100, "신문", "파머스는 최근 발생한 대규모 바이러스 사태에 따른 경기 침체에도 불구하고 매출액 및 손익부분이 크게 향상되었다고 밝혔습니다.", 10, 0.2f, 20));
        newsDataList.Add(new News(100, "신문", "울워즈 상반기 재무제표에 따르면 기대 실적을 훨씬 상회하는 것으로 나와 임직원에 대해 인센티브를 제공한다고  밝혔습니다.", 11, 0.2f, 20));
        newsDataList.Add(new News(100, "신문", "아웃벨 하반기 매출 및 손익 실적 발표에서 기대이상의 수준으로 나타나 추가 투자자들의 발길이 이어지고 있습니다.", 9, 0.2f, 20));
        newsDataList.Add(new News(100, "신문", "파머스의 정책기획실의 차장이 직원들을 강압적으로 폭언 및 폭행한 혐의로 경찰 수사가 진행중이라는 소식입니다.", 10, -0.2f, 20));
        newsDataList.Add(new News(100, "신문", "울워즈의 인사과의 부장이 직원들을 상습적으로 폭언을 한 혐의로 경찰 수사가 진행중입니다.",11, -0.2f, 20));
        newsDataList.Add(new News(100, "신문", "아웃벨 회장의 둘째 손자가 미국의 유학 생활중에 상습적으로 마약을 투약한 사실이 들어나 입국 현장에서 바로 검거되었습니다.", 9, -0.2f, 20));
        newsDataList.Add(new News(100, "신문", "파머스의 부회장의 장녀가 해외의 유학을 마치고 귀국길에 나섰다가 입국검사대에서 마약이 발견되어 즉시 연행되었습니다.", 10, -0.2f, 20));
        newsDataList.Add(new News(100, "신문", "울워즈 회장의 자택에 마약이 있다는 첩보를 받은 검찰이 압수수색을 진행한 결과 다량의 마약이 발견되어 체포영장이 발행되었습니다.", 11, -0.2f, 20));
        newsDataList.Add(new News(100, "신문", "아웃벨의 창업주가 전일 새벽 2시경에 타계 하였다고 밝혔습니다.", 9, -0.2f, 20));
        newsDataList.Add(new News(100, "신문", "파머스 전년도 법인세 및 취득세 부문에서 조직적으로 회계를 조작한 행위를 감사원이 발견하여 검찰에 관련내용을 넘겼다고 밝혔습니다. ", 10, -0.2f, 20));
        newsDataList.Add(new News(100, "신문", "울워즈 회장이 보유주식을 아들에게 상속하는 과정에서 대부분의 상속세를  공무원과 결탁하여 불법적으로 면제 받은 사실이 들어나 검찰이 수사에 착수하였습니다.", 11, -0.2f, 20));
        newsDataList.Add(new News(100, "신문", "아웃벨 특정 부서의 직원들의 카톡방에서 상습 성추행혐의가 발견되어 경찰 수사가 진행중입니다.", 9, -0.2f, 20));
        newsDataList.Add(new News(100, "신문", "파머스 상반기 영업이익률이 기대치에 비해 상당히 낮을것이라는 내부 관계자의 발언이 증권가에 돌아 많은 사람들이 동요하고 있습니다.", 10, -0.2f, 20));

        /*제약회사*/
        newsDataList.Add(new News(100, "신문", "베트남에 위치한 노바티수 생산공장에서 도적떼의 습격을 받아 출하 대기중이던 5천여개의 제품을 도난 당하였다고 발표했습니다.", 12, -0.1f, 30));
        newsDataList.Add(new News(100, "신문", "대규모 산불의 영향으로 로쉬의 생산공장이 화재로 모두 불타 버렸다는 소식입니다.", 13, -0.3f, 30));
        newsDataList.Add(new News(100, "신문", "화이쟈는 복숭아 알레르기에 효과적인 치료제의 임상 실험에 돌입했다고 발표했습니다.", 14, 0.2f, 20));
        newsDataList.Add(new News(100, "신문", "노바티수는 딸기 알레르기에 매우 효과적인 치료제 개발이 가시권에 들어왔으며 동물실험에 착수 했다고 발표했습니다", 12, 0.2f, 20));
        newsDataList.Add(new News(100, "신문", "로쉬는 사과 두드러기 원인 균에 매우 효과적인 치료제 개발에 성공하였으며 내달중에 임상실험에 들어간다고 발표했습니다.", 13, 0.2f, 20));
        newsDataList.Add(new News(100, "신문", "화이쟈는 오염된 물을 단하나의 알약으로 정화할 수 있는 원클리어워터클렌징캡슐을 개발했다고 밝혔다.", 14, 0.2f, 20));
        newsDataList.Add(new News(100, "신문", "노바티수는 오염되고 양분이 떨어진 토양을 건강하고 양분을 살릴수 있는 비료성분 개발에 성공했다고 밝혔습니다.", 12, 0.2f, 20));
        newsDataList.Add(new News(100, "신문", "로쉬는 전세계적으로 유행중인 인플루엔자에 대한 유전자 분석을 완료하였으며 곧 백신 개발에 착수 할 것이라 발표했습니다.", 13, 0.2f, 20));
        newsDataList.Add(new News(100, "신문", "화이쟈는 꼬루나 바이러스 대응으로 손세독제 및 마스크에 대한 공급을 내주중으로 실시한다고 밝혔습니다.", 14, 0.2f, 20));
        newsDataList.Add(new News(100, "신문", "노바티수는 금년도 화학노벨상을 받은 이그노벨씨를 전략제품기획실 수석으로 영입했다고 밝혔습니다.", 12, 0.2f, 20));
        newsDataList.Add(new News(100, "신문", "로쉬는 사외이사로 전 보건복지부 장관을 영입하였다고 밝혔습니다.전 보건복지부 장관은 재임 시절 능숙한 바이러스 대처 능력으로 호평을 받았던 인물이였습니다.", 13, 0.2f, 20));
        newsDataList.Add(new News(100, "신문", "화이쟈는 전략 신약 개발 및 연구부서의 총 책임자로 WHO의 바이러스 대응팀장을 영입했다고 밝혔습니다.", 14, 0.2f, 20));
        newsDataList.Add(new News(100, "신문", "노바티수는 두통치료제로 놀라운 성장을 보여주고있는 헤덱사를 인수한다고 밝혔습니다.", 12, 0.2f, 20));
        newsDataList.Add(new News(100, "신문", "화이쟈는 골다공증 치료제 개발에 성공한 골골사에 300억달러 가량을 투자하고 전략적 협력 관계를 맺어 기술적 교류를 진행할 것이라 밝혔습니다.", 14, 0.2f, 20));
        newsDataList.Add(new News(100, "신문", "로쉬는 피부 알레르기 치료제 판권을 소유중인 미국에 위치한 존앤존에게서 판매권을 부여받았다고 밝혔습니다.", 13, 0.2f, 20));
        newsDataList.Add(new News(100, "신문", "화이쟈는 홍반에 효과적인 효능을 보이는 청반을 미국 내 제약업계 1위 업체인 도브사에 납품 계약을 체결했다고 발표했습니다.", 14, 0.2f, 20));
        newsDataList.Add(new News(100, "신문", "노바티수는 아프리카 난민들의 보건 및 영양부족 사태 해결을 위해 영양키트 및 백신키트 300만 세트를 유니세프를 통해 제공한다고 발표했습니다.", 12, 0.2f, 20));
        newsDataList.Add(new News(100, "신문", "로쉬는 새로 출시한 신약의 판매량이 전작 대비 20 % 향상 되었다고 밝혔으며, 외부기관들은 A기업의 영업이익률개선이 이뤄질거라 평가하였습니다.", 13, 0.3f, 20));
        newsDataList.Add(new News(100, "신문", "화이쟈의 말라리아 치료제 신약품의 상반기 출하량이 기대 이상으로 높아 영업이익률이 대폭 향상될 것으로 예상됩니다.", 14, 0.2f, 20));
        newsDataList.Add(new News(100, "신문", "노바티수의 약만을 허가받고 경쟁기업의 약을 인허가받지 못하게 약품평가위원회에 조직적으로 로비를 진행한 사실이 들어나 검찰이 수사에 착수했습니다.", 12, -0.2f, 20));
        newsDataList.Add(new News(100, "신문", "로쉬의 약품처리공정부에서 폐기약을 처리하기 위한 비용을 아끼기위해 폐기물처리업체에 로비를 진행하여 불법 폐기한 사실이 드러났습니다.", 13, -0.2f, 20));
        newsDataList.Add(new News(100, "신문", "화이쟈의 전략약물제조부의 수석코치이자 화학노벨상 수상자인 갈게미씨가 급성심근경색으로 돌연사하였다고 밝혔습니다.", 14, -0.2f, 20));
        newsDataList.Add(new News(100, "신문", "노바티수는 약물중독성검사부에서 15년간 일해왔던 직원이 갑작스런 어지러움증 및 두통을 호소하며 응급실로 바로 후송되었지만 입원 3일만에 사망하였다고 밝혔습니다.", 12, -0.2f, 20));
        newsDataList.Add(new News(100, "신문", "로쉬의 차기 두통치료제로 기대를 받던 신약의 임상실험에서 부작용로 인해 사망자가 발생하여 전면 리콜 및 재검토에 들어갔다고 밝혔습니다.", 13, -0.2f, 20));
        newsDataList.Add(new News(100, "신문", "화이쟈의 임상실험자의 데이터 10만명치가 유출되어 경찰이 수사에 착수 했습니다.", 14, -0.2f, 20));
        newsDataList.Add(new News(100, "신문", "노바티수는 고위관계자에 따르면 차세대 암치료제 암크리너의 주요 성분 배합을 유출한 3인 조 산업스파이를 검거했다고 밝혔습니다.", 12, -0.2f, 20));
        newsDataList.Add(new News(100, "신문", "로쉬의 약품제조 및 저장시실이 위치한 지역에 대규모 산불이 발생하여 대량의 제품 소실이 불가피한 상황입니다.", 13, -0.2f, 20));
        newsDataList.Add(new News(100, "신문", "화이쟈의 고위관계자에 따르면 약품 공정공장이 위치한 지역에 높은 규모의 지진이 발생하여 당분간 제품 출하에 차질이 있을거라 전했습니다.", 14, -0.2f, 20));
        newsDataList.Add(new News(100, "신문", "노바티수가 전략 약물을 배송중이던 화물선이 해적에 나포되어 큰 손실을 입었다고 밝혔습니다.", 12, -0.2f, 20));
        newsDataList.Add(new News(100, "신문", "로쉬의 기대를 한몸에 받던 전략 암 세포종 치료제가 기존에 알려진 효과의 1할에도 못미친다고 전해져 많은 투자자들이 소송을 진행중에 있습니다.", 13, -0.2f, 20));
        newsDataList.Add(new News(100, "신문", "화이쟈의 새로운 제품 ‘비타칠백’에 유명 캐릭터 팡수가 모델로 선정됐다. 팡수는 남녀노소가 모두 좋아하는 캐릭터로 이번 협력을 통해 매출이 크게 상승할 것이 기대된다.", 14, 0.3f, 30));
        newsDataList.Add(new News(100, "신문", "노바티수가 불치병이라고 알려졌던 ‘동도리 동동 증후군’에 대한 신약 개발에 성공했다.노바티수는 10년 이상 200억 이상의 투자를 하면서 연구에 몰두한 결과 해당 병에 대한 완벽한 해결책을 찾아냈다고 밝혔다.", 12, 0.3f, 40));
        newsDataList.Add(new News(100, "신문", "로쉬가 치매 진단에 대한 새로운 특허를 얻었다. 로쉬는 새로운 방법을 통해 치매에 대해 높은 정확도로 미리 진단할 수 있다고 말했다.", 13, 0.3f, 40));
        newsDataList.Add(new News(100, "신문", "화이쟈가 개발한 홍삼 가공액이 생방송 오늘의 건강에 소개된 뒤 불티나게 팔리기 시작했다.오늘의 건강에서는 다른 제약 회사와 비교했을 때 원액이 가장 많이 함유되어 있어 효능이 뛰어나다고 방송했다.", 14, 0.3f, 20));
        newsDataList.Add(new News(100, "신문", "전세계적으로 팬더믹으로 선언된 ‘꼬로나’ 전염병으로 전국 마스크 대란이 일어나고 있다.  노바티수 브랜드의 마스크가 평소 가격의 10배이상 오르고 있다고 노바티수는 밝혔다.", 12, 0.3f, 40));
        newsDataList.Add(new News(100, "신문", "로쉬가 피 한방울로 100여 가지 질병을 진단할 수 있다고 벌여드렸던 투자가 모두 거짓이라는 게 밝혀졌다. 종합병원 원장 A씨는 의학적으로 불가능한 일이라며 못을 박았다. 투자자들은 소송 준비를 하고 있는 것으로 알려졌다.", 13, -0.3f, 30));
        newsDataList.Add(new News(100, "신문", "이제부터 편의점에서도 처방 없이 받을 수 있는 약을 구매할 수 있게 되었다.여러 약국 체인점을 운영하고 있는 화이쟈는 매출이 상당한 수준으로 줄을 것에 대해 우려하고 있다.", 14, 0.4f, 40));
        newsDataList.Add(new News(100, "신문", "노바티수에서 제조된 약물 ‘다나아’에 발암 물질이 발견되었다는 소식이 발표되었다. 이에 대한 소비자들의 항의와 환불 및 추가보상금 요구가 빗발치고 있다.", 12, -0.4f, 40));
        newsDataList.Add(new News(100, "신문", "빌 게이츠 마이크로소프트(MS) 창업자의 후원을 받고 있는 로쉬가 신종 코로나바이러스 감염증(코로나19) DNA 백신 임상 1상에 돌입했다.", 13, 0.4f, 40));
        newsDataList.Add(new News(100, "신문", "바이오제약회사 화이쟈가 미국에서 파킨슨병 치료제 온젠티스(성분명 오피카폰)의 판매 승인을 획득했다.", 14, 0.3f, 30));
        newsDataList.Add(new News(100, "신문", "노바티수는 베트남 태전그룹 계열사인 태전약품과 레모나 제품의 베트남 수출계약을 맺었다고 30일 밝혔다. 최근 베트남 현지에서는 건강에 관한 관심도가 높아짐에 따라 건강기능식품시장이 빠른 속도로 성장하고 있다.시장 분석보고서에 따르면 베트남 건강기능식품시장은 연평균 13 % 성장하고 있으며 2022년에는 유관시장 규모가 현재보다 약 41 % 커질 것으로 전망된다.", 12, 0.3f, 30));
        newsDataList.Add(new News(100, "신문", "부산 강서구의 로쉬의 물류창고에 화재가 발생했다.화재 현장에는 소방대원과 경찰관 160명과 차량 40여대가 투입돼 진화작업을 벌이고 있다.물류창고 1동이 대부분 소실된 것으로 보인다.", 13, -0.2f, 30));
        newsDataList.Add(new News(100, "신문", "경찰이 특정 의약품 처방을 대가로 제약회사 화이쟈로부터 리베이트르 받은 교수 등에 대한 수사를 착수했다.현재 서울 중랑경찰서는 배임수재 등 혐의로 A병원 성형외과 교수 3명과 제약회사 직원 1명 등 4명을 입건해 수사중이라고 밝혔다", 14, -0.3f, 40));
        newsDataList.Add(new News(100, "신문", "전염병과 맞서야 할 제약 업체가 오히려 “수퍼 전파자” 였다는 보도가 나왔다.미국 내 코로나 초기 집단 전파지 중 한 곳이 노바티수가 지난 2월 개최한 리더십 회의였다는 것이다.당시 회의엔 전 세계에서 온 170여명의 임원이 참여했으며, 이들은 함께 부페식사를 하며 거리낌 없이 서루 악수와 볼 키스를 나눈 것으로 알려졌다.", 12, -0.4f, 40));
    }
}
