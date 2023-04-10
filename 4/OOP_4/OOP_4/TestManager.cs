using OOP_4.StressTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4
{
    internal class TestManager
    {
        public static TestCaseResult[] GenerateResult()
        {
            TestCaseResult[] result = new TestCaseResult[10];
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                var randMaterial = (Material)rnd.Next(0, 5);
                var randCrossSection = (CrossSection)rnd.Next(0, 4);
                var randResult = (TestResult)rnd.Next(0, 2);

                var a = (randMaterial, randCrossSection, randResult);

                if (a.randResult == TestResult.Fail)
                {
                    if (a.randMaterial == Material.Aluminium)
                    {
                        result[i] = new TestCaseResult { ReasonForFailure = $"Алюминий не выдержал нагрузки при {a.randCrossSection} сечении.", Result = a.randResult };
                        continue;
                    }
                    if (a.randMaterial == Material.StainlessSteel)
                    {
                        if (a.randCrossSection == CrossSection.ZShaped)
                        {
                            result[i] = new TestCaseResult { ReasonForFailure = "Нержавеющая сталь не выдержала нагрузки при Z-образном сечении.", Result = a.randResult };
                            continue;
                        }
                    }
                    result[i] = new TestCaseResult { ReasonForFailure = $"Неизвестная причина. Материал {a.randMaterial} не выдержал нагрузку при {a.randCrossSection} сечении", Result = a.randResult };
                    continue;
                }
                result[i] = new TestCaseResult { Result = a.randResult };
            }
            return result;
        }
    }
}
