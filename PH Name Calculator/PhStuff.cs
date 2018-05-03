using System;
using System.Collections.Generic;
using System.Linq;
using HtmlAgilityPack;
using System.Net;

namespace PH_Name_Calculator
{
    class PhStuff
    {
        public delegate void UpdateProgressDelegate(string url);
        public event UpdateProgressDelegate UpdateProgress;
        private int _max;
        private WebClient web = new WebClient();
        private HtmlDocument d;
        private HtmlWeb w = new HtmlWeb();
        private HtmlNodeCollection _usernode;
        public PhStuff()
        {
        }

        /// <summary>
        /// Return the users and comments, according to the given information
        /// </summary>
        /// <param name="topic"> A topic name to searh for comments </param>
        /// <param name="commentcount"> The amount of comments that we want to return </param>
        /// <param name="_currentmin"> The starting point of comments </param>
        /// <returns></returns>
        public List<Users> GetAllUser(string topic, int commentcount, int _currentmin)
        {
            return _GetAllUsers(topic, commentcount, _currentmin);
        }
        private List<Users> _GetAllUsers(string _topic, int _commentcount, int min)
        {
            List<Users> _users = new List<Users>();
            if(min == default(int))
            {
                min = 1;
            }
            if (_commentcount > 201)
            {
                _max = min + 200;
                _UploadList(_users, _topic, min, _max);
                do
                {
                    if ((_max + 201) < _commentcount)
                    {
                        _max += 200;
                        min += 200;
                    }
                    else
                    {
                         min = (_max + 1);
                        _max = _commentcount;
                    }                 
                    _UploadList(_users, _topic, min, _max);
                } while (_max != _commentcount);
            }
            else
            {
                _max = _commentcount;
                _UploadList(_users, _topic, min, _max);
            }
             return _users;
        }
       
        private void _UploadList(List<Users> _users, string _topic, int _mincom, int _maxcom)
        {
            string url = "https://prohardver.hu/tema/" + _topic + "/hsz_" + _mincom + "-" + _maxcom + ".html";
            try
            {
                d = w.Load(url);
                ProgressUpdate(url);
                _usernode = d.DocumentNode.SelectNodes("//*[@class=\"hlist head flc\"]");
                foreach (HtmlNode node in _usernode)
                {
                    try
                    {
                        if (_users.Any(EgyFelh => EgyFelh.username == node.SelectSingleNode(".//a[2]").InnerText))
                        {
                            int index = _users.FindIndex(EgyFelh => EgyFelh.username == node.SelectSingleNode(".//a[2]").InnerText);
                            _users[index].commentcount++;
                        }
                        else
                        {
                            _users.Add(new Users(node.SelectSingleNode(".//a[2]").InnerText));
                        }
                    }
                    catch (NullReferenceException)
                    {

                    }
                }
            }
            catch(NullReferenceException)
            {

            }
        }
       
        /// <summary>
        /// Returns the profile picture of the currently selected user
        /// </summary>
        /// <param name="username">  </param>
        /// <returns></returns>
        public string Profilepicture(string username)
        {
            return _ProfilePicture(username);
        }
        private string _ProfilePicture(string _username)
        {
            d = w.Load("https://prohardver.hu/tag/" + _username + ".html");
            return "https://prohardver.hu" + d.DocumentNode.SelectSingleNode("//*[@id=\"page\"]/div/div[1]/p/img").Attributes["src"].Value.ToString();
        }

        /// <summary>
        /// Returns the three types of comments per user
        /// </summary>
        /// <param name="username"> A username connected to the comments </param>
        /// <returns></returns>
        public IEnumerable <string> returnComments(string username)
        {
            return _returnComment(username);
        }
        private IEnumerable<string> _returnComment(string _username)
        {
            string first,second,third = "";
            try
            {
                d = w.Load("https://prohardver.hu/tag/" + _username + ".html");
                first = d.DocumentNode.SelectSingleNode("//*[@id=\"page\"]").SelectSingleNode("//*[@class=\"input user\"]").SelectSingleNode("//*[@class=\"tiny\"][1]").SelectSingleNode(".//p[2]").InnerHtml;
                second = d.DocumentNode.SelectSingleNode("//*[@id=\"page\"]").SelectSingleNode("//*[@class=\"input user\"]").SelectSingleNode("//*[@class=\"tiny\"][2]").SelectSingleNode(".//p[2]").InnerHtml;
                third = d.DocumentNode.SelectSingleNode("//*[@id=\"page\"]").SelectSingleNode("//*[@class=\"input user\"]").SelectSingleNode("//*[@class=\"tiny\"][3]").SelectSingleNode(".//p[2]").InnerHtml;
            }
            catch (NullReferenceException)
            {
                first = second = third = "";
            }
            yield return first;
            yield return second;
            yield return third;
        }

        /// <summary>
        /// Normalizes the username, by removing Upper-cased characters, dots, and white-spaces
        /// </summary>
        /// <param name="notnormal"></param>
        /// <returns></returns>
        public string Normalusername(string notnormal)
        {
            return _normalusername(notnormal);
        }
        private string _normalusername(string _notnormal)
        {
            _notnormal = _notnormal.Replace(' ', '_').Replace('.', '_').Normalize(System.Text.NormalizationForm.FormD);
            System.Text.StringBuilder output = new System.Text.StringBuilder();
            foreach (char c in _notnormal)
            {
                System.Globalization.UnicodeCategory uc = System.Globalization.CharUnicodeInfo.GetUnicodeCategory(c);
                if (uc != System.Globalization.UnicodeCategory.NonSpacingMark)
                {
                    output.Append(c);
                }
            }
            return output.ToString().ToLower();
        }

        /// <summary>
        /// Searches the maximum amount of comment in the current topic
        /// </summary>
        /// <param name="topic"> Returns a string representation of the current maximum comments in the topic </param>
        /// <returns></returns>
        public string maxComment(string topic)
        {
            return _maxComment(topic);
        }
        private string _maxComment(string _topic)
        {
            try
            {
                w = new HtmlWeb();
                //return w.Load("https://prohardver.hu/tema/" + _topic + "/friss.html").DocumentNode.SelectSingleNode("//*[@id=\"navi_btm_pages\"]/div/div/ul/li[last()]/a/span[2]").InnerText;
                return w.Load("https://prohardver.hu/").DocumentNode.InnerText;
            }
            catch (NullReferenceException ex)
            {
                return "";
            }
        }

        internal void ProgressUpdate(string _url)
        {
            UpdateProgress(_url);
        }
    }
}
