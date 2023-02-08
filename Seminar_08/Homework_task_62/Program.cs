﻿/*
** Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
*/

void Print2DArray(int[,] data)
{
    for (int row = 0; row < data.GetLength(0); row++)
    {
        for (int col = 0; col < data.GetLength(1); col++)
            Console.Write($"{data[row, col],5}");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FillArray(int[,] matrix)
{
    (int min, int max) horizontal = (0, matrix.GetLength(1) - 1);
    (int min, int max) vertical = (1, matrix.GetLength(0) - 1);
    (int row, int col) current = (0, 0);
    (int x, int y) step = (1, 1);
    int num = 1;
    matrix[0, 0] = num++;
    while (num <= matrix.GetLength(0) * matrix.GetLength(1))
    {
        while ((step.x > 0 && current.col < horizontal.max) || (step.x < 0 && current.col > horizontal.min))
        {
            current.col += step.x;
            matrix[current.row, current.col] = num++;
        }
        while ((step.y > 0 && current.row < vertical.max) || (step.y < 0 && current.row > vertical.min))
        {
            current.row += step.y;
            matrix[current.row, current.col] = num++;
        }
        if (current.col == horizontal.min && step.x < 0) horizontal.min++;
        if (current.col == horizontal.max && step.x > 0) horizontal.max--;
        if (current.row == vertical.max && step.y > 0) vertical.max--;
        if (current.row == vertical.min && step.y < 0) vertical.min++;

        step.y *= -1;
        step.x *= -1;
    }
}
////////////////////////////////////////
(int rows, int cols) size = (4, 4);
int[,] array = new int[size.rows, size.cols];
FillArray(array);
Console.WriteLine($"spiral filling of the matrix[{size.rows},{size.cols}]");
Print2DArray(array);


/*
 * OUTPUT=4x4======================================
 * spiral filling of the matrix[4,4]
 *  1    2    3    4
 * 12   13   14    5
 * 11   16   15    6
 * 10    9    8    7
 * 
 * ==10x10=========================================
 * spiral filling of the matrix[10,10]
 *  1    2    3    4    5    6    7    8    9   10
 * 36   37   38   39   40   41   42   43   44   11
 * 35   64   65   66   67   68   69   70   45   12
 * 34   63   84   85   86   87   88   71   46   13
 * 33   62   83   96   97   98   89   72   47   14
 * 32   61   82   95  100   99   90   73   48   15
 * 31   60   81   94   93   92   91   74   49   16
 * 30   59   80   79   78   77   76   75   50   17
 * 29   58   57   56   55   54   53   52   51   18
 * 28   27   26   25   24   23   22   21   20   19
 * 
 * ==30x20==========================================================================================
 * spiral filling of the matrix[30,20]
 *  1    2    3    4    5    6    7    8    9   10   11   12   13   14   15   16   17   18   19   20
 * 96   97   98   99  100  101  102  103  104  105  106  107  108  109  110  111  112  113  114   21
 * 95  184  185  186  187  188  189  190  191  192  193  194  195  196  197  198  199  200  115   22
 * 94  183  264  265  266  267  268  269  270  271  272  273  274  275  276  277  278  201  116   23
 * 93  182  263  336  337  338  339  340  341  342  343  344  345  346  347  348  279  202  117   24
 * 92  181  262  335  400  401  402  403  404  405  406  407  408  409  410  349  280  203  118   25
 * 91  180  261  334  399  456  457  458  459  460  461  462  463  464  411  350  281  204  119   26
 * 90  179  260  333  398  455  504  505  506  507  508  509  510  465  412  351  282  205  120   27
 * 89  178  259  332  397  454  503  544  545  546  547  548  511  466  413  352  283  206  121   28
 * 88  177  258  331  396  453  502  543  576  577  578  549  512  467  414  353  284  207  122   29
 * 87  176  257  330  395  452  501  542  575  600  579  550  513  468  415  354  285  208  123   30
 * 86  175  256  329  394  451  500  541  574  599  580  551  514  469  416  355  286  209  124   31
 * 85  174  255  328  393  450  499  540  573  598  581  552  515  470  417  356  287  210  125   32
 * 84  173  254  327  392  449  498  539  572  597  582  553  516  471  418  357  288  211  126   33
 * 83  172  253  326  391  448  497  538  571  596  583  554  517  472  419  358  289  212  127   34
 * 82  171  252  325  390  447  496  537  570  595  584  555  518  473  420  359  290  213  128   35
 * 81  170  251  324  389  446  495  536  569  594  585  556  519  474  421  360  291  214  129   36
 * 80  169  250  323  388  445  494  535  568  593  586  557  520  475  422  361  292  215  130   37
 * 79  168  249  322  387  444  493  534  567  592  587  558  521  476  423  362  293  216  131   38
 * 78  167  248  321  386  443  492  533  566  591  588  559  522  477  424  363  294  217  132   39
 * 77  166  247  320  385  442  491  532  565  590  589  560  523  478  425  364  295  218  133   40
 * 76  165  246  319  384  441  490  531  564  563  562  561  524  479  426  365  296  219  134   41
 * 75  164  245  318  383  440  489  530  529  528  527  526  525  480  427  366  297  220  135   42
 * 74  163  244  317  382  439  488  487  486  485  484  483  482  481  428  367  298  221  136   43
 * 73  162  243  316  381  438  437  436  435  434  433  432  431  430  429  368  299  222  137   44
 * 72  161  242  315  380  379  378  377  376  375  374  373  372  371  370  369  300  223  138   45
 * 71  160  241  314  313  312  311  310  309  308  307  306  305  304  303  302  301  224  139   46
 * 70  159  240  239  238  237  236  235  234  233  232  231  230  229  228  227  226  225  140   47
 * 69  158  157  156  155  154  153  152  151  150  149  148  147  146  145  144  143  142  141   48
 * 68   67   66   65   64   63   62   61   60   59   58   57   56   55   54   53   52   51   50   49
 */