/*
 * Copyright (C) 2014 The Libphonenumber Authors
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

/* This file is automatically generated by {@link BuildMetadataProtoFromXml}.
 * Please don't modify it directly.
 */

namespace Google.PhoneNumbers {

using System;
using System.Collections.Generic;

public class CountryCodeToRegionCodeMap {
  // A mapping from a country code to the region codes which denote the
  // country/region represented by that country code. In the case of multiple
  // countries sharing a calling code, such as the NANPA countries, the one
  // indicated with "isMainCountryForCode" in the metadata should be first.
  internal static Dictionary<int, List<String>> getCountryCodeToRegionCodeMap() {
    // The capacity is set to %d as there are %d different entries,
    // and this offers a load factor of roughly 0.75.
    Dictionary<int, List<String>> countryCodeToRegionCodeMap =
        new Dictionary<int, List<String>>(286);

    List<String> listWithRegionCode;

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("AC");
    countryCodeToRegionCodeMap.Add(247, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("AD");
    countryCodeToRegionCodeMap.Add(376, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("AE");
    countryCodeToRegionCodeMap.Add(971, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("AF");
    countryCodeToRegionCodeMap.Add(93, listWithRegionCode);

    listWithRegionCode = new List<String>(25);
    listWithRegionCode.Add("US");
    listWithRegionCode.Add("AG");
    listWithRegionCode.Add("AI");
    listWithRegionCode.Add("AS");
    listWithRegionCode.Add("BB");
    listWithRegionCode.Add("BM");
    listWithRegionCode.Add("BS");
    listWithRegionCode.Add("CA");
    listWithRegionCode.Add("DM");
    listWithRegionCode.Add("DO");
    listWithRegionCode.Add("GD");
    listWithRegionCode.Add("GU");
    listWithRegionCode.Add("JM");
    listWithRegionCode.Add("KN");
    listWithRegionCode.Add("KY");
    listWithRegionCode.Add("LC");
    listWithRegionCode.Add("MP");
    listWithRegionCode.Add("MS");
    listWithRegionCode.Add("PR");
    listWithRegionCode.Add("SX");
    listWithRegionCode.Add("TC");
    listWithRegionCode.Add("TT");
    listWithRegionCode.Add("VC");
    listWithRegionCode.Add("VG");
    listWithRegionCode.Add("VI");
    countryCodeToRegionCodeMap.Add(1, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("AL");
    countryCodeToRegionCodeMap.Add(355, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("AM");
    countryCodeToRegionCodeMap.Add(374, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("AO");
    countryCodeToRegionCodeMap.Add(244, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("AR");
    countryCodeToRegionCodeMap.Add(54, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("AT");
    countryCodeToRegionCodeMap.Add(43, listWithRegionCode);

    listWithRegionCode = new List<String>(3);
    listWithRegionCode.Add("AU");
    listWithRegionCode.Add("CC");
    listWithRegionCode.Add("CX");
    countryCodeToRegionCodeMap.Add(61, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("AW");
    countryCodeToRegionCodeMap.Add(297, listWithRegionCode);

    listWithRegionCode = new List<String>(2);
    listWithRegionCode.Add("FI");
    listWithRegionCode.Add("AX");
    countryCodeToRegionCodeMap.Add(358, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("AZ");
    countryCodeToRegionCodeMap.Add(994, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("BA");
    countryCodeToRegionCodeMap.Add(387, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("BD");
    countryCodeToRegionCodeMap.Add(880, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("BE");
    countryCodeToRegionCodeMap.Add(32, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("BF");
    countryCodeToRegionCodeMap.Add(226, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("BG");
    countryCodeToRegionCodeMap.Add(359, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("BH");
    countryCodeToRegionCodeMap.Add(973, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("BI");
    countryCodeToRegionCodeMap.Add(257, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("BJ");
    countryCodeToRegionCodeMap.Add(229, listWithRegionCode);

    listWithRegionCode = new List<String>(3);
    listWithRegionCode.Add("GP");
    listWithRegionCode.Add("BL");
    listWithRegionCode.Add("MF");
    countryCodeToRegionCodeMap.Add(590, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("BN");
    countryCodeToRegionCodeMap.Add(673, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("BO");
    countryCodeToRegionCodeMap.Add(591, listWithRegionCode);

    listWithRegionCode = new List<String>(2);
    listWithRegionCode.Add("CW");
    listWithRegionCode.Add("BQ");
    countryCodeToRegionCodeMap.Add(599, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("BR");
    countryCodeToRegionCodeMap.Add(55, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("BT");
    countryCodeToRegionCodeMap.Add(975, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("BW");
    countryCodeToRegionCodeMap.Add(267, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("BY");
    countryCodeToRegionCodeMap.Add(375, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("BZ");
    countryCodeToRegionCodeMap.Add(501, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("CD");
    countryCodeToRegionCodeMap.Add(243, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("CF");
    countryCodeToRegionCodeMap.Add(236, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("CG");
    countryCodeToRegionCodeMap.Add(242, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("CH");
    countryCodeToRegionCodeMap.Add(41, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("CI");
    countryCodeToRegionCodeMap.Add(225, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("CK");
    countryCodeToRegionCodeMap.Add(682, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("CL");
    countryCodeToRegionCodeMap.Add(56, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("CM");
    countryCodeToRegionCodeMap.Add(237, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("CN");
    countryCodeToRegionCodeMap.Add(86, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("CO");
    countryCodeToRegionCodeMap.Add(57, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("CR");
    countryCodeToRegionCodeMap.Add(506, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("CU");
    countryCodeToRegionCodeMap.Add(53, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("CV");
    countryCodeToRegionCodeMap.Add(238, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("CY");
    countryCodeToRegionCodeMap.Add(357, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("CZ");
    countryCodeToRegionCodeMap.Add(420, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("DE");
    countryCodeToRegionCodeMap.Add(49, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("DJ");
    countryCodeToRegionCodeMap.Add(253, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("DK");
    countryCodeToRegionCodeMap.Add(45, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("DZ");
    countryCodeToRegionCodeMap.Add(213, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("EC");
    countryCodeToRegionCodeMap.Add(593, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("EE");
    countryCodeToRegionCodeMap.Add(372, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("EG");
    countryCodeToRegionCodeMap.Add(20, listWithRegionCode);

    listWithRegionCode = new List<String>(2);
    listWithRegionCode.Add("MA");
    listWithRegionCode.Add("EH");
    countryCodeToRegionCodeMap.Add(212, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("ER");
    countryCodeToRegionCodeMap.Add(291, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("ES");
    countryCodeToRegionCodeMap.Add(34, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("ET");
    countryCodeToRegionCodeMap.Add(251, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("FJ");
    countryCodeToRegionCodeMap.Add(679, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("FK");
    countryCodeToRegionCodeMap.Add(500, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("FM");
    countryCodeToRegionCodeMap.Add(691, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("FO");
    countryCodeToRegionCodeMap.Add(298, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("FR");
    countryCodeToRegionCodeMap.Add(33, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("GA");
    countryCodeToRegionCodeMap.Add(241, listWithRegionCode);

    listWithRegionCode = new List<String>(4);
    listWithRegionCode.Add("GB");
    listWithRegionCode.Add("GG");
    listWithRegionCode.Add("IM");
    listWithRegionCode.Add("JE");
    countryCodeToRegionCodeMap.Add(44, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("GE");
    countryCodeToRegionCodeMap.Add(995, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("GF");
    countryCodeToRegionCodeMap.Add(594, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("GH");
    countryCodeToRegionCodeMap.Add(233, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("GI");
    countryCodeToRegionCodeMap.Add(350, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("GL");
    countryCodeToRegionCodeMap.Add(299, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("GM");
    countryCodeToRegionCodeMap.Add(220, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("GN");
    countryCodeToRegionCodeMap.Add(224, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("GQ");
    countryCodeToRegionCodeMap.Add(240, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("GR");
    countryCodeToRegionCodeMap.Add(30, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("GT");
    countryCodeToRegionCodeMap.Add(502, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("GW");
    countryCodeToRegionCodeMap.Add(245, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("GY");
    countryCodeToRegionCodeMap.Add(592, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("HK");
    countryCodeToRegionCodeMap.Add(852, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("HN");
    countryCodeToRegionCodeMap.Add(504, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("HR");
    countryCodeToRegionCodeMap.Add(385, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("HT");
    countryCodeToRegionCodeMap.Add(509, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("HU");
    countryCodeToRegionCodeMap.Add(36, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("ID");
    countryCodeToRegionCodeMap.Add(62, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("IE");
    countryCodeToRegionCodeMap.Add(353, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("IL");
    countryCodeToRegionCodeMap.Add(972, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("IN");
    countryCodeToRegionCodeMap.Add(91, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("IO");
    countryCodeToRegionCodeMap.Add(246, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("IQ");
    countryCodeToRegionCodeMap.Add(964, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("IR");
    countryCodeToRegionCodeMap.Add(98, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("IS");
    countryCodeToRegionCodeMap.Add(354, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("IT");
    countryCodeToRegionCodeMap.Add(39, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("JO");
    countryCodeToRegionCodeMap.Add(962, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("JP");
    countryCodeToRegionCodeMap.Add(81, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("KE");
    countryCodeToRegionCodeMap.Add(254, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("KG");
    countryCodeToRegionCodeMap.Add(996, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("KH");
    countryCodeToRegionCodeMap.Add(855, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("KI");
    countryCodeToRegionCodeMap.Add(686, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("KM");
    countryCodeToRegionCodeMap.Add(269, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("KP");
    countryCodeToRegionCodeMap.Add(850, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("KR");
    countryCodeToRegionCodeMap.Add(82, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("KW");
    countryCodeToRegionCodeMap.Add(965, listWithRegionCode);

    listWithRegionCode = new List<String>(2);
    listWithRegionCode.Add("RU");
    listWithRegionCode.Add("KZ");
    countryCodeToRegionCodeMap.Add(7, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("LA");
    countryCodeToRegionCodeMap.Add(856, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("LB");
    countryCodeToRegionCodeMap.Add(961, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("LI");
    countryCodeToRegionCodeMap.Add(423, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("LK");
    countryCodeToRegionCodeMap.Add(94, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("LR");
    countryCodeToRegionCodeMap.Add(231, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("LS");
    countryCodeToRegionCodeMap.Add(266, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("LT");
    countryCodeToRegionCodeMap.Add(370, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("LU");
    countryCodeToRegionCodeMap.Add(352, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("LV");
    countryCodeToRegionCodeMap.Add(371, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("LY");
    countryCodeToRegionCodeMap.Add(218, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("MC");
    countryCodeToRegionCodeMap.Add(377, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("MD");
    countryCodeToRegionCodeMap.Add(373, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("ME");
    countryCodeToRegionCodeMap.Add(382, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("MG");
    countryCodeToRegionCodeMap.Add(261, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("MH");
    countryCodeToRegionCodeMap.Add(692, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("MK");
    countryCodeToRegionCodeMap.Add(389, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("ML");
    countryCodeToRegionCodeMap.Add(223, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("MM");
    countryCodeToRegionCodeMap.Add(95, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("MN");
    countryCodeToRegionCodeMap.Add(976, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("MO");
    countryCodeToRegionCodeMap.Add(853, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("MQ");
    countryCodeToRegionCodeMap.Add(596, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("MR");
    countryCodeToRegionCodeMap.Add(222, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("MT");
    countryCodeToRegionCodeMap.Add(356, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("MU");
    countryCodeToRegionCodeMap.Add(230, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("MV");
    countryCodeToRegionCodeMap.Add(960, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("MW");
    countryCodeToRegionCodeMap.Add(265, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("MX");
    countryCodeToRegionCodeMap.Add(52, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("MY");
    countryCodeToRegionCodeMap.Add(60, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("MZ");
    countryCodeToRegionCodeMap.Add(258, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("NA");
    countryCodeToRegionCodeMap.Add(264, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("NC");
    countryCodeToRegionCodeMap.Add(687, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("NE");
    countryCodeToRegionCodeMap.Add(227, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("NF");
    countryCodeToRegionCodeMap.Add(672, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("NG");
    countryCodeToRegionCodeMap.Add(234, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("NI");
    countryCodeToRegionCodeMap.Add(505, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("NL");
    countryCodeToRegionCodeMap.Add(31, listWithRegionCode);

    listWithRegionCode = new List<String>(2);
    listWithRegionCode.Add("NO");
    listWithRegionCode.Add("SJ");
    countryCodeToRegionCodeMap.Add(47, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("NP");
    countryCodeToRegionCodeMap.Add(977, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("NR");
    countryCodeToRegionCodeMap.Add(674, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("NU");
    countryCodeToRegionCodeMap.Add(683, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("NZ");
    countryCodeToRegionCodeMap.Add(64, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("OM");
    countryCodeToRegionCodeMap.Add(968, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("PA");
    countryCodeToRegionCodeMap.Add(507, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("PE");
    countryCodeToRegionCodeMap.Add(51, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("PF");
    countryCodeToRegionCodeMap.Add(689, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("PG");
    countryCodeToRegionCodeMap.Add(675, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("PH");
    countryCodeToRegionCodeMap.Add(63, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("PK");
    countryCodeToRegionCodeMap.Add(92, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("PL");
    countryCodeToRegionCodeMap.Add(48, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("PM");
    countryCodeToRegionCodeMap.Add(508, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("PS");
    countryCodeToRegionCodeMap.Add(970, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("PT");
    countryCodeToRegionCodeMap.Add(351, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("PW");
    countryCodeToRegionCodeMap.Add(680, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("PY");
    countryCodeToRegionCodeMap.Add(595, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("QA");
    countryCodeToRegionCodeMap.Add(974, listWithRegionCode);

    listWithRegionCode = new List<String>(2);
    listWithRegionCode.Add("RE");
    listWithRegionCode.Add("YT");
    countryCodeToRegionCodeMap.Add(262, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("RO");
    countryCodeToRegionCodeMap.Add(40, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("RS");
    countryCodeToRegionCodeMap.Add(381, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("RW");
    countryCodeToRegionCodeMap.Add(250, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("SA");
    countryCodeToRegionCodeMap.Add(966, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("SB");
    countryCodeToRegionCodeMap.Add(677, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("SC");
    countryCodeToRegionCodeMap.Add(248, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("SD");
    countryCodeToRegionCodeMap.Add(249, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("SE");
    countryCodeToRegionCodeMap.Add(46, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("SG");
    countryCodeToRegionCodeMap.Add(65, listWithRegionCode);

    listWithRegionCode = new List<String>(2);
    listWithRegionCode.Add("SH");
    listWithRegionCode.Add("TA");
    countryCodeToRegionCodeMap.Add(290, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("SI");
    countryCodeToRegionCodeMap.Add(386, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("SK");
    countryCodeToRegionCodeMap.Add(421, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("SL");
    countryCodeToRegionCodeMap.Add(232, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("SM");
    countryCodeToRegionCodeMap.Add(378, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("SN");
    countryCodeToRegionCodeMap.Add(221, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("SO");
    countryCodeToRegionCodeMap.Add(252, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("SR");
    countryCodeToRegionCodeMap.Add(597, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("SS");
    countryCodeToRegionCodeMap.Add(211, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("ST");
    countryCodeToRegionCodeMap.Add(239, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("SV");
    countryCodeToRegionCodeMap.Add(503, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("SY");
    countryCodeToRegionCodeMap.Add(963, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("SZ");
    countryCodeToRegionCodeMap.Add(268, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("TD");
    countryCodeToRegionCodeMap.Add(235, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("TG");
    countryCodeToRegionCodeMap.Add(228, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("TH");
    countryCodeToRegionCodeMap.Add(66, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("TJ");
    countryCodeToRegionCodeMap.Add(992, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("TK");
    countryCodeToRegionCodeMap.Add(690, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("TL");
    countryCodeToRegionCodeMap.Add(670, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("TM");
    countryCodeToRegionCodeMap.Add(993, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("TN");
    countryCodeToRegionCodeMap.Add(216, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("TO");
    countryCodeToRegionCodeMap.Add(676, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("TR");
    countryCodeToRegionCodeMap.Add(90, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("TV");
    countryCodeToRegionCodeMap.Add(688, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("TW");
    countryCodeToRegionCodeMap.Add(886, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("TZ");
    countryCodeToRegionCodeMap.Add(255, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("UA");
    countryCodeToRegionCodeMap.Add(380, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("UG");
    countryCodeToRegionCodeMap.Add(256, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("UY");
    countryCodeToRegionCodeMap.Add(598, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("UZ");
    countryCodeToRegionCodeMap.Add(998, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("VA");
    countryCodeToRegionCodeMap.Add(379, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("VE");
    countryCodeToRegionCodeMap.Add(58, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("VN");
    countryCodeToRegionCodeMap.Add(84, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("VU");
    countryCodeToRegionCodeMap.Add(678, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("WF");
    countryCodeToRegionCodeMap.Add(681, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("WS");
    countryCodeToRegionCodeMap.Add(685, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("YE");
    countryCodeToRegionCodeMap.Add(967, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("ZA");
    countryCodeToRegionCodeMap.Add(27, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("ZM");
    countryCodeToRegionCodeMap.Add(260, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("ZW");
    countryCodeToRegionCodeMap.Add(263, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("001");
    countryCodeToRegionCodeMap.Add(800, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("001");
    countryCodeToRegionCodeMap.Add(808, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("001");
    countryCodeToRegionCodeMap.Add(870, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("001");
    countryCodeToRegionCodeMap.Add(878, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("001");
    countryCodeToRegionCodeMap.Add(881, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("001");
    countryCodeToRegionCodeMap.Add(882, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("001");
    countryCodeToRegionCodeMap.Add(883, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("001");
    countryCodeToRegionCodeMap.Add(888, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("001");
    countryCodeToRegionCodeMap.Add(979, listWithRegionCode);

    return countryCodeToRegionCodeMap;
  }
}
}