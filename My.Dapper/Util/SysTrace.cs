using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace My.Dapper {
    public class SysTrace {
        private static string _enableSystemTraceLog = "";
        private static string EnableSystemTraceLog {
            get {
                if(string.IsNullOrEmpty(_enableSystemTraceLog)) {
                    _enableSystemTraceLog = ConfigurationManager.AppSettings["SystemTraceLog"];
                }
                return _enableSystemTraceLog;
            }
        }

        internal static void WriteLine(string moduleName,long elapsedMilliseconds) {
            if("FALSE".Equals(EnableSystemTraceLog,StringComparison.CurrentCultureIgnoreCase)) {
                return;
            }
            Trace.WriteLine(string.Format("{0} - {1}():\t{2}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss fff"),moduleName,elapsedMilliseconds));
        }

        internal static void Init() {
            if("FALSE".Equals(EnableSystemTraceLog,StringComparison.CurrentCultureIgnoreCase)) {
                return;
            }
            string fileName = AppDomain.CurrentDomain.BaseDirectory + "\\System_tracelog.txt";
            if(File.Exists(fileName)) {
                FileInfo fileInfo = new FileInfo(fileName);
                if(fileInfo.Length > 1024 * 100) {
                    File.Move(fileName,fileName.Replace("system_tracelog.txt","System_tracelog_" + DateTime.Now.ToString("yyyyMMdd-HHmmss-fff") + ".txt"));
                }
            }

            Trace.Listeners.Add(new TextWriterTraceListener(fileName));
            Trace.AutoFlush = true;
            Trace.WriteLine("---Begin Trace------------------------------------------------------------------");
        }

        internal static void Close() {
            if("FALSE".Equals(EnableSystemTraceLog,StringComparison.CurrentCultureIgnoreCase)) {
                return;
            }
            Trace.WriteLine("---End Trace--------------------------------------------------------------------\r\n");
            Trace.Flush();
            Trace.Close();
        }
    }
}
