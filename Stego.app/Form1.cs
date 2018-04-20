﻿using Library.Image;
using Library.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stego.app
{
    public partial class Form1 : Form
    {
        public StegoImage stego;

        const string ImageFileFilter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG|All files (*.*)|*.*";

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSelectFile_Click(object sender, EventArgs e)
        {
            using(var ofd = new OpenFileDialog())
            {
                ofd.Filter = ImageFileFilter;
                ofd.AddExtension = true;
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    stego = new StegoImage(ofd.FileName);
                }
            }
        }

        private void BtnEncode_Click(object sender, EventArgs e)
        {
            stego.InsertMessage(@"IspoketheotherdayofthecolossalmilitarydisasterwhichoccurredwhentheFrenchHighCommandfailedtowithdrawthenorthernArmiesfromBelgiumatthemomentwhentheyknewthattheFrenchfrontwasdecisivelybrokenatSedanandontheMeuse.ThisdelayentailedthelossoffifteenorsixteenFrenchdivisionsandthrewoutofactionforthecriticalperiodthewholeoftheBritishExpeditionaryForce.OurArmyand120,000FrenchtroopswereindeedrescuedbytheBritishNavyfromDunkirkbutonlywiththelossoftheircannon,vehiclesandmodernequipment.Thislossinevitablytooksomeweekstorepair,andinthefirsttwoofthoseweeksthebattleinFrancehasbeenlost.WhenweconsidertheheroicresistancemadebytheFrenchArmyagainstheavyoddsinthisbattle,theenormouslossesinflictedupontheenemyandtheevidentexhaustionoftheenemy,itmaywellbethethoughtthatthese25divisionsofthebest-trainedandbest-equippedtroopsmighthaveturnedthescale.However,GeneralWeygandhadtofightwithoutthem.OnlythreeBritishdivisionsortheirequivalentwereabletostandinthelinewiththeirFrenchcomrades.Theyhavesufferedseverely,buttheyhavefoughtwell.WesenteverymanwecouldtoFranceasfastaswecouldre-equipandtransporttheirformations.Iamnotrecitingthesefactsforthepurposeofrecrimination.ThatIjudgetobeutterlyfutileandevenharmful.Wecannotaffordit.Irecitetheminordertoexplainwhyitwaswedidnothave,aswecouldhavehad,betweentwelveandfourteenBritishdivisionsfightinginthelineinthisgreatbattleinsteadofonlythree.NowIputallthisaside.Iputitontheshelf,fromwhichthehistorians,whentheyhavetime,willselecttheirdocumentstotelltheirstories.Wehavetothinkofthefutureandnotofthepast.Thisalsoappliesinasmallwaytoourownaffairsathome.TherearemanywhowouldholdaninquestintheHouseofCommonsontheconductoftheGovernments--andofParliaments,fortheyareinit,too--duringtheyearswhichleduptothiscatastrophe.Theyseektoindictthosewhowereresponsiblefortheguidanceofouraffairs.Thisalsowouldbeafoolishandperniciousprocess.Therearetoomanyinit.Leteachmansearchhisconscienceandsearchhisspeeches.Ifrequentlysearchmine.OfthisIamquitesure,thatifweopenaquarrelbetweenthepastandthepresent,weshallfindthatwehavelostthefuture.Therefore,IcannotacceptthedrawingofanydistinctionsbetweenmembersofthepresentGovernment.ItwasformedatamomentofcrisisinordertouniteallthePartiesandallsectionsofopinion.IthasreceivedthealmostunanimoussupportofbothHousesofParliament.Itsmembersaregoingtostandtogether,and,subjecttotheauthorityoftheHouseofCommons,wearegoingtogovernthecountryandfightthewar.ItisabsolutelynecessaryatatimelikethisthateveryMinisterwhotrieseachdaytodohisdutyshallberespected;andtheirsubordinatesmustknowthattheirchiefsarenotthreatenedmen,menwhoareheretodayandgonetomorrow,butthattheirdirectionsmustbepunctuallyandfaithfullyobeyed.Withoutthisconcentratedpowerwecannotfacewhatliesbeforeus.IshouldnotthinkitwouldbeveryadvantageousfortheHousetoprolongthisdebatethisafternoonunderconditionsofpublicstress.Manyfactsarenotclearthatwillbeclearinashorttime.WearetohaveasecretsessiononThursday,andIshouldthinkthatwouldbeabetteropportunityforthemanyearnestexpressionsofopinionwhichmemberswilldesiretomakeandfortheHousetodiscussvitalmatterswithouthavingeverythingreadthenextmorningbyourdangerousfoes.Thedisastrousmilitaryeventswhichhavehappenedduringthepastfortnighthavenotcometomewithanysenseofsurprise.Indeed,IindicatedafortnightagoasclearlyasIcouldtotheHousethattheworstpossibilitieswereopen;andImadeitperfectlyclearthenthatwhateverhappenedinFrancewouldmakenodifferencetotheresolveofBritainandtheBritishEmpiretofighton,ifnecessaryforyears,ifnecessaryalone.DuringthelastfewdayswehavesuccessfullybroughtoffthegreatmajorityofthetroopswehadonthelineofcommunicationinFrance;andseven-eighthsofthetroopswehavesenttoFrancesincethebeginningofthewar--thatistosay,about350,000outof400,000men--aresafelybackinthiscountry.OthersarestillfightingwiththeFrench,andfightingwithconsiderablesuccessintheirlocalencountersagainsttheenemy.Wehavealsobroughtbackagreatmassofstores,riflesandmunitionsofallkindswhichhadbeenaccumulatedinFranceduringthelastninemonths.Wehave,therefore,inthisIslandtodayaverylargeandpowerfulmilitaryforce.Thisforcecomprisesallourbest-trainedandourfinesttroops,includingscoresofthousandsofthosewhohavealreadymeasuredtheirqualityagainsttheGermansandfoundthemselvesatnodisadvantage.WehaveunderarmsatthepresenttimeinthisIslandoveramillionandaquartermen.BehindthesewehavetheLocalDefenseVolunteers,numberinghalfamillion,onlyaportionofwhom,however,areyetarmedwithriflesorotherfirearms.WehaveincorporatedintoourDefenseForceseverymanforwhomwehaveaweapon.Weexpectverylargeadditionstoourweaponsinthenearfuture,andinpreparationforthisweintendforthwithtocallup,drillandtrainfurtherlargenumbers.Thosewhoarenotcalledup,orelseareemployedduringthevastbusinessofmunitionsproductioninallitsbranches--andtheirramificationsareinnumerable--willservetheircountrybestbyremainingattheirordinaryworkuntiltheyreceivetheirsummons.WehavealsooverhereDominionsarmies.TheCanadianshadactuallylandedinFrance,buthavenowbeensafelywithdrawn,muchdisappointed,butinperfectorder,withalltheirartilleryandequipment.Andtheseveryhigh-classforcesfromtheDominionswillnowtakepartinthedefenseoftheMotherCountry.LesttheaccountwhichIhavegivenoftheselargeforcesshouldraisethequestion:WhydidtheynottakepartinthegreatbattleinFrance?Imustmakeitclearthat,apartfromthedivisionstrainingandorganizingathome,onlytwelvedivisionswereequippedtofightuponascalewhichjustifiedtheirbeingsentabroad.AndthiswasfullyuptothenumberwhichtheFrenchhadbeenledtoexpectwouldbeavailableinFranceattheninthmonthofthewar.Therestofourforcesathomehaveafightingvalueforhomedefensewhichwill,ofcourse,steadilyincreaseeveryweekthatpasses.Thus,theinvasionofGreatBritainwouldatthistimerequirethetransportationacrosstheseaofhostilearmiesonaverylargescale,andaftertheyhadbeensotransportedtheywouldhavetobecontinuallymaintainedwithallthemassesofmunitionsandsupplieswhicharerequiredforcontinuousbattle--ascontinuousbattleitwillsurelybe.HereiswherewecometotheNavy--andafterall,wehaveaNavy.SomepeopleseemtoforgetthatwehaveaNavy.Wemustremindthem.ForthelastthirtyyearsIhavebeenconcernedindiscussionsaboutthepossibilitiesofoverseainvasion,andItooktheresponsibilityonbehalfoftheAdmiralty,atthebeginningofthelastwar,ofallowingallregulartroopstobesentoutofthecountry.Thatwasaveryserioussteptotake,becauseourTerritorialshadonlyjustbeencalledupandwerequiteuntrained.Therefore,thisIslandwasforseveralmonthsparticularlydenudedoffightingtroops.TheAdmiraltyhadconfidenceatthattimeintheirabilitytopreventamassinvasioneventhoughatthattimetheGermanshadamagnificentbattlefleetintheproportionof10to16,eventhoughtheywerecapableoffightingageneralengagementeverydayandanyday,whereasnowtheyhaveonlyacoupleofheavyshipsworthspeakingof--theScharnhorstandtheGneisenau.WearealsotoldthattheItalianNavyistocomeoutandgainseasuperiorityinthesewaters.Iftheyseriouslyintendit,IshallonlysaythatweshallbedelightedtoofferSignorMussoliniafreeandsafeguardedpassagethroughtheStraitofGibraltarinorderthathemayplaytheparttowhichheaspires.ThereisageneralcuriosityintheBritishFleettofindoutwhethertheItaliansareuptotheleveltheywereatinthelastwarorwhethertheyhavefallenoffatall.Therefore,itseemstomethatasfarassea-borneinvasiononagreatscaleisconcerned,wearefarmorecapableofmeetingittodaythanwewereatmanyperiodsinthelastwarandduringtheearlymonthsofthiswar,beforeourothertroopsweretrained,andwhiletheB.E.F.hadproceededabroad.Now,theNavyhaveneverpretendedtobeabletopreventraidsbybodiesof5,000or10,000menflungsuddenlyacrossandthrownashoreatseveralpointsonthecoastsomedarknightorfoggymorning.Theefficacyofseapower,especiallyundermodernconditions,dependsupontheinvadingforcebeingoflargesize;Ithastobeoflargesize,inviewofourmilitarystrength,tobeofanyuse.Ifitisoflargesize,thentheNavyhavesomethingtheycanfindandmeetand,asitwere,biteon.Now,wemustrememberthatevenfivedivisions,howeverlightlyequipped,wouldrequire200to250ships,andwithmodernairreconnaissanceandphotographyitwouldnotbeeasytocollectsuchanarmada,marshalit,andconductitacrosstheseawithoutanypowerfulnavalforcestoescortit;andtherewouldbeverygreatpossibilities,toputitmildly,thatthisarmadawouldbeinterceptedlongbeforeitreachedthecoast,andallthemendrownedintheseaor,attheworstblowntopieceswiththeirequipmentwhiletheyweretryingtoland.Wealsohaveagreatsystemofminefields,recentlystronglyreinforced,throughwhichwealoneknowthechannels.Iftheenemytriestosweeppassagesthroughtheseminefields,itwillbethetaskoftheNavytodestroythemine-sweepersandanyotherforcesemployedtoprotectthem.Thereshouldbenodifficultyinthis,owingtoourgreatsuperiorityatsea.Thosearetheregular,well-tested,well-provedargumentsonwhichwehavereliedduringmanyyearsinpeaceandwar.Butthequestioniswhetherthereareanynewmethodsbywhichthosesolidassurancescanbecircumvented.Oddasitmayseem,someattentionhasbeengiventothisbytheAdmiralty,whoseprimedutyandresponsibilityistodestroyanylargesea-borneexpeditionbeforeitreaches,oratthemomentwhenitreaches,theseshores.Itwouldnotbeagoodthingformetogointodetailsofthis.Itmightsuggestideastootherpeoplewhichtheyhavenotthoughtof,andtheywouldnotbelikelytogiveusanyoftheirideasinexchange.AllIwillsayisthatuntiringvigilanceandmind-searchingmustbedevotedtothesubject,becausetheenemyiscraftyandcunningandfullofnoveltreacheriesandstratagems.TheHousemaybeassuredthattheutmostingenuityisbeingdisplayedandimaginationisbeingevokedfromlargenumbersofcompetentofficers,well-trainedintacticsandthoroughlyuptodate,tomeasureandcounterworknovelpossibilities.Untiringvigilanceanduntiringsearchingofthemindisbeing,andmustbe,devotedtothesubject,because,remember,theenemyiscraftyandthereisnodirtytrickhewillnotdo.Somepeoplewillaskwhy,then,wasitthattheBritishNavywasnotabletopreventthemovementofalargearmyfromGermanyintoNorwayacrosstheSkagerrak?ButtheconditionsintheChannelandintheNorthSeaareinnowaylikethosewhichprevailintheSkagerrak.IntheSkagerrak,becauseofthedistance,wecouldgivenoairsupporttooursurfaceships,andconsequently,lyingaswedidclosetotheenemy'smainairpower,wewerecompelledtouseonlyoursubmarines.Wecouldnotenforcethedecisiveblockadeorinterruptionwhichispossiblefromsurfacevessels.Oursubmarinestookaheavytollbutcouldnot,bythemselves,preventtheinvasionofNorway.IntheChannelandintheNorthSea,ontheotherhand,oursuperiornavalsurfaceforces,aidedbyoursubmarines,willoperatewithcloseandeffectiveairassistance.Thisbringsme,naturally,tothegreatquestionofinvasionfromtheair,andoftheimpendingstrugglebetweentheBritishandGermanAirForces.ItseemsquiteclearthatnoinvasiononascalebeyondthecapacityofourlandforcestocrushspeedilyislikelytotakeplacefromtheairuntilourAirForcehasbeendefinitelyoverpowered.Inthemeantime,theremayberaidsbyparachutetroopsandattempteddescentsofairbornesoldiers.Weshouldbeabletogivethosegentryawarmreceptionbothintheairandontheground,iftheyreachitinanyconditiontocontinuethedispute.Butthegreatquestionis:CanwebreakHitler'sairweapon?Now,ofcourse,itisaverygreatpitythatwehavenotgotanAirForceatleastequaltothatofthemostpowerfulenemywithinstrikingdistanceoftheseshores.ButwehaveaverypowerfulAirForcewhichhasproveditselffarsuperiorinquality,bothinmenandinmanytypesofmachine,towhatwehavemetsofarinthenumerousandfierceairbattleswhichhavebeenfoughtwiththeGermans.InFrance,wherewewereataconsiderabledisadvantageandlostmanymachinesonthegroundwhentheywerestandingroundtheaerodromes,wewereaccustomedtoinflictintheairlossesofasmuchastwoandtwo-and-a-halftoone.InthefightingoverDunkirk,whichwasasortofno-man's-land,weundoubtedlybeattheGermanAirForce,andgainedthemasteryofthelocalair,inflictingherealossofthreeorfourtoonedayafterday.Anyonewholooksatthephotographswhichwerepublishedaweekorsoagoofthere-embarkation,showingthemassesoftroopsassembledonthebeachandforminganidealtargetforhoursatatime,mustrealizethatthisre-embarkationwouldnothavebeenpossibleunlesstheenemyhadresignedallhopeofrecoveringairsuperiorityatthattimeandatthatplace.InthedefenseofthisIslandtheadvantagestothedefenderswillbemuchgreaterthantheywereinthefightingaroundDunkirk.WehopetoimproveontherateofthreeorfourtoonewhichwasrealizedatDunkirk;andinadditionallourinjuredmachinesandtheircrewswhichgetdownsafely--and,surprisingly,averygreatmanyinjuredmachinesandmendogetdownsafelyinmodernairfighting--allofthesewillfall,inanattackupontheseIslands,onfriendlysoilandlivetofightanotherday;whereasalltheinjuredenemymachinesandtheircomplementswillbetotallossesasfarasthewarisconcerned.DuringthegreatbattleinFrance,wegaveverypowerfulandcontinuousaidtotheFrenchArmy,bothbyfightersandbombers;butinspiteofeverykindofpressureweneverwouldallowtheentiremetropolitanfighterstrengthoftheAirForcetobeconsumed.Thisdecisionwaspainful,butitwasalsoright,becausethefortunesofthebattleinFrancecouldnothavebeendecisivelyaffectedevenifwehadthrowninourentirefighterforce.Thatbattlewaslostbytheunfortunatestrategicalopening,bytheextraordinaryandunforseenpowerofthearmoredcolumns,andbythegreatpreponderanceoftheGermanArmyinnumbers.OurfighterAirForcemighteasilyhavebeenexhaustedasamereaccidentinthatgreatstruggle,andthenweshouldhavefoundourselvesatthepresenttimeinaveryseriousplight.Butasitis,IamhappytoinformtheHousethatourfighterstrengthisstrongeratthepresenttimerelativelytotheGermans,whohavesufferedterriblelosses,thanithaseverbeen;andconsequentlywebelieveourselvespossessedofthecapacitytocontinuethewarintheairunderbetterconditionsthanwehaveeverexperiencedbefore.Ilookforwardconfidentlytotheexploitsofourfighterpilots--thesesplendidmen,thisbrilliantyouth--whowillhavethegloryofsavingtheirnativeland,theirislandhome,andalltheylove,fromthemostdeadlyofallattacks.Thereremains,ofcourse,thedangerofbombingattacks,whichwillcertainlybemadeverysoonuponusbythebomberforcesoftheenemy.ItistruethattheGermanbomberforceissuperiorinnumberstoours;butwehaveaverylargebomberforcealso,whichweshallusetostrikeatmilitarytargetsinGermanywithoutintermission.Idonotatallunderratetheseverityoftheordealwhichliesbeforeus;butIbelieveourcountrymenwillshowthemselvescapableofstandinguptoit,likethebravemenofBarcelona,andwillbeabletostanduptoit,andcarryoninspiteofit,atleastaswellasanyotherpeopleintheworld.Muchwilldependuponthis;everymanandeverywomanwillhavethechancetoshowthefinestqualitiesoftheirrace,andrenderthehighestservicetotheircause.Forallofus,atthistime,whateveroursphere,ourstation,ouroccupationorourduties,itwillbeahelptorememberthefamouslines:Henothingcommondidormean,Uponthatmemorablescene.IhavethoughtitrightuponthisoccasiontogivetheHouseandthecountrysomeindicationofthesolid,practicalgroundsuponwhichwebaseourinflexibleresolvetocontinuethewar.Thereareagoodmanypeoplewhosay,'Nevermind.Winorlose,sinkorswim,betterdiethansubmittotyranny--andsuchatyranny.'AndIdonotdissociatemyselffromthem.ButIcanassurethemthatourprofessionaladvisersofthethreeServicesunitedlyadvisethatweshouldcarryonthewar,andthattherearegoodandreasonablehopesoffinalvictory.Wehavefullyinformedandconsultedalltheself-governingDominions,thesegreatcommunitiesfarbeyondtheoceanswhohavebeenbuiltuponourlawsandonourcivilization,andwhoareabsolutelyfreetochoosetheircourse,butareabsolutelydevotedtotheancientMotherland,andwhofeelthemselvesinspiredbythesameemotionswhichleadmetostakeourallupondutyandhonor.Wehavefullyconsultedthem,andIhavereceivedfromtheirPrimeMinisters,Mr.MackenzieKingofCanada,Mr.MenziesofAustralia,Mr.FraserofNewZealand,andGeneralSmutsofSouthAfrica--thatwonderfulman,withhisimmenseprofoundmind,andhiseyewatchingfromadistancethewholepanoramaofEuropeanaffairs--Ihavereceivedfromalltheseeminentmen,whoallhaveGovernmentsbehindthemelectedonwidefranchises,whoarealltherebecausetheyrepresentthewilloftheirpeople,messagescouchedinthemostmovingtermsinwhichtheyendorseourdecisiontofighton,anddeclarethemselvesreadytoshareourfortunesandtoperseveretotheend.Thatiswhatwearegoingtodo.Wemaynowaskourselves:Inwhatwayhasourpositionworsenedsincethebeginningofthewar?IthasworsenedbythefactthattheGermanshaveconqueredalargepartofthecoastlineofWesternEurope,andmanysmallcountrieshavebeenoverrunbythem.Thisaggravatesthepossibilitiesofairattackandaddstoournavalpreoccupations.Itinnowaydiminishes,butonthecontrarydefinitelyincreases,thepowerofourlong-distanceblockade.Similarly,theentranceofItalyintothewarincreasesthepowerofourlong-distanceblockade.Wehavestoppedtheworstleakbythat.WedonotknowwhethermilitaryresistancewillcometoanendinFranceornot,butshoulditdoso,thenofcoursetheGermanswillbeabletoconcentratetheirforces,bothmilitaryandindustrial,uponus.ButforthereasonsIhavegiventotheHousethesewillnotbefoundsoeasytoapply.Ifinvasionhasbecomemoreimminent,asnodoubtithas,we,beingrelievedfromthetaskofmaintainingalargearmyinFrance,havefarlargerandmoreefficientforcestomeetit.IfHitlercanbringunderhisdespoticcontroltheindustriesofthecountrieshehasconquered,thiswilladdgreatlytohisalreadyvastarmamentoutput.Ontheotherhand,thiswillnothappenimmediately,andwearenowassuredofimmense,continuousandincreasingsupportinsuppliesandmunitionsofallkindsfromtheUnitedStates;andespeciallyofaeroplanesandpilotsfromtheDominionsandacrosstheoceanscomingfromregionswhicharebeyondthereachofenemybombers.Idonotseehowanyofthesefactorscanoperatetoourdetrimentonbalancebeforethewintercomes;andthewinterwillimposeastrainupontheNaziregime,withalmostallEuropewrithingandstarvingunderitscruelheel,which,foralltheirruthlessness,willrunthemveryhard.Wemustnotforgetthatfromthemomentwhenwedeclaredwaronthe3rdSeptemberitwasalwayspossibleforGermanytoturnallherAirForceuponthiscountry,togetherwithanyotherdevicesofinvasionshemightconceive,andthatFrancecouldhavedonelittleornothingtopreventherdoingso.Wehave,therefore,livedunderthisdanger,inprincipleandinaslightlymodifiedform,duringallthesemonths.Inthemeanwhile,however,wehaveenormouslyimprovedourmethodsofdefense,andwehavelearnedwhatwehadnorighttoassumeatthebeginning,namely,thattheindividualaircraftandtheindividualBritishpilothaveasureanddefinitesuperiority.Therefore,incastingupthisdreadbalancesheetandcontemplatingourdangerswithadisillusionedeye,Iseegreatreasonforintensevigilanceandexertion,butnonewhateverforpanicordespair.DuringthefirstfouryearsofthelastwartheAlliesexperiencednothingbutdisasteranddisappointment.Thatwasourconstantfear:oneblowafteranother,terriblelosses,frightfuldangers.Everythingmiscarried.AndyetattheendofthosefouryearsthemoraleoftheAllieswashigherthanthatoftheGermans,whohadmovedfromoneaggressivetriumphtoanother,andwhostoodeverywheretriumphantinvadersofthelandsintowhichtheyhadbroken.Duringthatwarwerepeatedlyaskedourselvesthequestion:'Howarewegoingtowin?'Andnoonewasableevertoansweritwithmuchprecision,untilattheend,quitesuddenly,quiteunexpectedly,ourterriblefoecollapsedbeforeus,andweweresogluttedwithvictorythatinourfollywethrewitaway.WedonotyetknowwhatwillhappeninFranceorwhethertheFrenchresistancewillbeprolonged,bothinFranceandintheFrenchEmpireoverseas.TheFrenchGovernmentwillbethrowingawaygreatopportunitiesandcastingadrifttheirfutureiftheydonotcontinuethewarinaccordancewiththeirtreatyobligations,fromwhichwehavenotfeltabletoreleasethem.TheHousewillhavereadthehistoricdeclarationinwhich,atthedesireofmanyFrenchmen--andofourownhearts--wehaveproclaimedourwillingnessatthedarkesthourinFrenchhistorytoconcludeaunionofcommoncitizenshipinthisstruggle.HowevermattersmaygoinFranceorwiththeFrenchGovernment,orotherFrenchGovernments,weinthisIslandandintheBritishEmpirewillneverloseoursenseofcomradeshipwiththeFrenchpeople.Ifwearenowcalledupontoendurewhattheyhavebeensuffering,weshallemulatetheircourage,andiffinalvictoryrewardsourtoilstheyshallsharethegains,aye,andfreedomshallberestoredtoall.Weabatenothingofourjustdemands;notonejotortittledowerecede.Czechs,Poles,Norwegians,Dutch,Belgianshavejoinedtheircausestoourown.Alltheseshallberestored.WhatGeneralWeygandcalledtheBattleofFranceisover.IexpectthattheBattleofBritainisabouttobegin.UponthisbattledependsthesurvivalofChristiancivilization.UponitdependsourownBritishlife,andthelongcontinuityofourinstitutionsandourEmpire.Thewholefuryandmightoftheenemymustverysoonbeturnedonus.HitlerknowsthathewillhavetobreakusinthisIslandorlosethewar.Ifwecanstanduptohim,allEuropemaybefreeandthelifeoftheworldmaymoveforwardintobroad,sunlituplands.Butifwefail,thenthewholeworld,includingtheUnitedStates,includingallthatwehaveknownandcaredfor,willsinkintotheabyssofanewDarkAgemademoresinister,andperhapsmoreprotracted,bythelightsofpervertedscience.Letusthereforebraceourselvestoourduties,andsobearourselvesthatiftheBritishEmpireanditsCommonwealthlastforathousandyears,menwillstillsay,'Thiswastheirfinesthour.'");
            Console.WriteLine(Converter.AsciiToBinary("testing"));
            // testing = 01110100011001010111001101110100011010010110111001100111
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stego.ReadImage();
        }
    }
}
