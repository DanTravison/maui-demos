#region Copyright Syncfusion Inc. 2001-2022.
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Maui.Maps;
using System.Collections.ObjectModel;

namespace SampleBrowser.Maui.Maps;

public class RangeViewModel
{
    public ObservableCollection<CountryDensity> WorldPopulationDensity { get; set; }

    public RangeViewModel()
    {
        WorldPopulationDensity = new ObservableCollection<CountryDensity>()
        {
           new CountryDensity("Monaco", 19341),
           new CountryDensity("Macao", 21055),
           new CountryDensity("Singapore", 8041),
           new CountryDensity("Hong kong", 6677),
           new CountryDensity("Gibraltar", 5620),
           new CountryDensity("Bahrain", 1913),
           new CountryDensity("Holy See", 1820),
           new CountryDensity("Maldives", 1719),
           new CountryDensity("Malta", 1390),
           new CountryDensity("Bangladesh", 1087),
           new CountryDensity("Sint Maarten", 1261),
           new CountryDensity("Bermuda", 1184),
           new CountryDensity("Channel Islands", 915),
           new CountryDensity("State of Palestine", 808),
           new CountryDensity("Saint-Martin", 654),
           new CountryDensity("Mayotte", 686),
           new CountryDensity("Taiwan", 652),
           new CountryDensity("Barbados", 667),
           new CountryDensity("Lebanon", 656),
           new CountryDensity("Mauritius", 644),
           new CountryDensity("Aruba", 588),
           new CountryDensity("San Marino", 554),
           new CountryDensity("Nauru", 508),
           new CountryDensity("Korea", 511),
           new CountryDensity("Rwanda", 467),
           new CountryDensity("Netherlands", 457),
           new CountryDensity("Comoros", 372),
           new CountryDensity("India", 411),
           new CountryDensity("Burundi", 402),
           new CountryDensity("Saint-Barth�lemy", 398),
           new CountryDensity("Haiti", 401),
           new CountryDensity("Israel", 431),
           new CountryDensity("Tuvalu", 443),
           new CountryDensity("Belgium", 376),
           new CountryDensity("Curacao", 367),
           new CountryDensity("Philippines", 356),
           new CountryDensity("Reunion", 351),
           new CountryDensity("Martinique", 333),
           new CountryDensity("Japan", 337),
           new CountryDensity("Sri Lanka", 324),
           new CountryDensity("Grenada", 324),
           new CountryDensity("Marshall Islands", 323),
           new CountryDensity("Puerto Rico", 343),
           new CountryDensity("Vietnam", 289),
           new CountryDensity("El Salvador", 305),
           new CountryDensity("Guam", 302),
           new CountryDensity("Saint Lucia", 337),
           new CountryDensity("United States Virgin Islands", 302),
           new CountryDensity("Pakistan", 241),
           new CountryDensity("Saint Vincent and the Grenadines", 283),
           new CountryDensity("United Kingdom", 277),
           new CountryDensity("American Samoa", 279),
           new CountryDensity("Cayman Islands", 243),
           new CountryDensity("Jamaica", 267),
           new CountryDensity("Trinidad and Tobago", 271),
           new CountryDensity("Qatar", 240),
           new CountryDensity("Guadeloupe", 235),
           new CountryDensity("Luxembourg", 234),
           new CountryDensity("Germany", 233),
           new CountryDensity("Kuwait", 232),
           new CountryDensity("Gambia", 202),
           new CountryDensity("Liechtenstein", 237),
           new CountryDensity("Uganda", 177),
           new CountryDensity("Sao Tome and Principe", 219),
           new CountryDensity("Nigeria", 212),
           new CountryDensity("Dominican Rep.", 221),
           new CountryDensity("Antigua and Barbuda", 218),
           new CountryDensity("Switzerland", 207),
           new CountryDensity("Dem. Rep. Korea", 212),
           new CountryDensity("Seychelles", 213),
           new CountryDensity("Italy", 201),
           new CountryDensity("Saint Kitts and Nevis", 201),
           new CountryDensity("Nepal", 191),
           new CountryDensity("Malawi", 153),
           new CountryDensity("British Virgin Islands", 197),
           new CountryDensity("Guatemala", 158),
           new CountryDensity("Anguilla", 162),
           new CountryDensity("Andorra", 165),
           new CountryDensity("Micronesia", 160),
           new CountryDensity("China", 149),
           new CountryDensity("Togo", 139),
           new CountryDensity("Indonesia", 140),
           new CountryDensity("Isle of Man", 147),
           new CountryDensity("Kiribati", 160),
           new CountryDensity("Tonga", 138),
           new CountryDensity("Czech Rep.", 135),
           new CountryDensity("Cabo Verde", 135),
           new CountryDensity("Thailand", 135),
           new CountryDensity("Ghana", 125),
           new CountryDensity("Denmark", 133),
           new CountryDensity("Tokelau", 110),
           new CountryDensity("Cyprus", 129),
           new CountryDensity("Northern Mariana Islands", 124),
           new CountryDensity("Poland", 122),
           new CountryDensity("Moldova", 120),
           new CountryDensity("Azerbaijan", 115),
           new CountryDensity("France", 118),
           new CountryDensity("United Arab Emirates", 115),
           new CountryDensity("Ethiopia", 99),
           new CountryDensity("Jordan", 112),
           new CountryDensity("Slovakia", 111),
           new CountryDensity("Portugal", 111),
           new CountryDensity("Sierra Leone", 106),
           new CountryDensity("Turkey", 105),
           new CountryDensity("Austria", 106),
           new CountryDensity("Benin", 100),
           new CountryDensity("Hungary", 104),
           new CountryDensity("Cuba", 103),
           new CountryDensity("Albania", 100),
           new CountryDensity("Armenia", 99),
           new CountryDensity("Slovenia", 102),
           new CountryDensity("Egypt", 98),
           new CountryDensity("Serbia", 100),
           new CountryDensity("Costa Rica", 98),
           new CountryDensity("Malaysia", 95),
           new CountryDensity("Dominica", 95),
           new CountryDensity("Syria", 92),
           new CountryDensity("Cambodia", 90),
           new CountryDensity("Kenya", 87),
           new CountryDensity("Spain", 92),
           new CountryDensity("Iraq", 88),
           new CountryDensity("Timor-Leste", 85),
           new CountryDensity("Honduras", 85),
           new CountryDensity("Senegal", 81),
           new CountryDensity("Romania", 82),
           new CountryDensity("Myanmar", 79),
           new CountryDensity("Brunei Darussalam", 74),
           new CountryDensity("C�te d'Ivoire", 78),
           new CountryDensity("Morocco", 81),
           new CountryDensity("Macedonia", 81),
           new CountryDensity("Greece", 80),
           new CountryDensity("Wallis and Futuna Islands", 82),
           new CountryDensity("Bonaire, Sint Eustatius and Saba", 77),
           new CountryDensity("Uzbekistan", 73),
           new CountryDensity("French Polynesia", 69),
           new CountryDensity("Burkina Faso", 72),
           new CountryDensity("Tunisia", 71),
           new CountryDensity("Ukraine", 73),
           new CountryDensity("Croatia", 73),
           new CountryDensity("Cook Islands", 74),
           new CountryDensity("Ireland", 69),
           new CountryDensity("Ecuador", 67),
           new CountryDensity("Lesotho", 69),
           new CountryDensity("Samoa", 69),
           new CountryDensity("Guinea-Bissau", 52),
           new CountryDensity("Tajikistan", 64),
           new CountryDensity("Eswatini", 65),
           new CountryDensity("Tanzania", 59),
           new CountryDensity("Mexico", 64),
           new CountryDensity("Bosnia and Herz.", 65),
           new CountryDensity("Bulgaria", 64),
           new CountryDensity("Afghanistan", 57),
           new CountryDensity("Panama", 55),
           new CountryDensity("Georgia", 57),
           new CountryDensity("Yemen", 54),
           new CountryDensity("Cameroon", 53),
           new CountryDensity("Nicaragua", 50),
           new CountryDensity("Guinea", 50),
           new CountryDensity("Liberia", 43),
           new CountryDensity("Iran", 50),
           new CountryDensity("Eq. Guinea", 47),
           new CountryDensity("Montserrat", 48),
           new CountryDensity("Fiji", 48),
           new CountryDensity("South Africa", 47),
           new CountryDensity("Madagascar", 45),
           new CountryDensity("Montenegro", 45),
           new CountryDensity("Belarus", 46),
           new CountryDensity("Colombia", 43),
           new CountryDensity("Lithuania", 43),
           new CountryDensity("Djibouti", 41),
           new CountryDensity("Turks and Caicos Islands", 40),
           new CountryDensity("Mozambique", 37),
           new CountryDensity("Dem. Rep. Congo", 36),
           new CountryDensity("Palau", 39),
           new CountryDensity("Bahamas", 28),
           new CountryDensity("Zimbabwe", 37),
           new CountryDensity("United States", 34),
           new CountryDensity("Eritrea", 29),
           new CountryDensity("Faroe Islands", 35),
           new CountryDensity("Kyrgyzstan", 32),
           new CountryDensity("Venezuela", 32),
           new CountryDensity("Lao PDR", 30),
           new CountryDensity("Estonia", 29),
           new CountryDensity("Latvia", 30),
           new CountryDensity("Angola", 25),
           new CountryDensity("Peru", 25),
           new CountryDensity("Chile", 25),
           new CountryDensity("Brazil", 25),
           new CountryDensity("Somalia", 24),
           new CountryDensity("Vanuatu", 24),
           new CountryDensity("Saint Pierre and Miquelon", 24),
           new CountryDensity("Sudan", 22),
           new CountryDensity("Zambia", 23),
           new CountryDensity("Sweden", 22),
           new CountryDensity("Solomon Islands", 23),
           new CountryDensity("Bhutan", 20),
           new CountryDensity("Uruguay", 20),
           new CountryDensity("Papua New Guinea", 19),
           new CountryDensity("Niger", 18),
           new CountryDensity("Algeria", 18),
           new CountryDensity("S. Sudan", 20),
           new CountryDensity("New Zealand", 18),
           new CountryDensity("Finland", 16),
           new CountryDensity("Paraguay", 17),
           new CountryDensity("Belize", 17),
           new CountryDensity("Mali", 15),
           new CountryDensity("Argentina", 16),
           new CountryDensity("Oman", 16),
           new CountryDensity("Saudi Arabia", 16),
           new CountryDensity("Congo", 15),
           new CountryDensity("New Caledonia", 15),
           new CountryDensity("Saint Helena", 14),
           new CountryDensity("Norway", 16),
           new CountryDensity("Chad", 12),
           new CountryDensity("Turkmenistan", 12),
           new CountryDensity("Bolivia", 10),
           new CountryDensity("Russia", 9),
           new CountryDensity("Gabon", 8),
           new CountryDensity("Central African Rep.", 7),
           new CountryDensity("Kazakhstan", 7),
           new CountryDensity("Niue", 6),
           new CountryDensity("Mauritania", 4),
           new CountryDensity("Canada", 4),
           new CountryDensity("Botswana", 4),
           new CountryDensity("Guyana", 4),
           new CountryDensity("Libya", 4),
           new CountryDensity("Suriname", 4),
           new CountryDensity("French Guiana", 3),
           new CountryDensity("Iceland", 3),
           new CountryDensity("Australia", 3),
           new CountryDensity("Namibia", 3),
           new CountryDensity("W. Sahara", 2),
           new CountryDensity("Mongolia", 2),
           new CountryDensity("Falkland Is.", 0.3),
           new CountryDensity("Greenland", 0.03),
        };
    }
}